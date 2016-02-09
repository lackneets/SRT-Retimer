using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace readerT_Retimer
{
    public partial class Form1 : Form
    {
        const string CRLF = "\r\n";

        StreamReader reader;
        Encoding coding;
        StreamWriter writer;

        double timeDiff = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            fd_fileDialog.Title = "開啟字幕檔...";
            fd_fileDialog.Filter = "字幕檔案(*.srt)|*.srt|所有檔案(*.*)|*.*";
            fd_fileDialog.ShowDialog();
        }

        private void fd_fileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //開啟檔案
            try
            {
                reader = new StreamReader(fd_fileDialog.FileName, Encoding.GetEncoding(0));
                coding = reader.CurrentEncoding;
                txt_input.Text = reader.ReadToEnd();
                reader.Close();
                tab_preview.SelectTab(0);
                
            }
            catch
            {
                MessageBox.Show("無法開啟檔案", "開啟字幕", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //UI
            this.Text = fd_fileDialog.SafeFileName + " - SRT Resync 0.1";
            btn_saveFile.Enabled = false;
            txt_output.Text = "";
            btn_retime.Enabled = true;
            
        }

        private void fd_saveFile_FileOk(object sender, CancelEventArgs e)
        {
            //寫入檔案
            try
            {
                writer = new StreamWriter(fd_saveFile.FileName, false, coding);
                writer.Write(txt_output.Text);
                writer.Close();
            }
            catch 
            {
                MessageBox.Show("檔案儲存失敗","另存新檔", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_saveFile_Click(object sender, EventArgs e)
        {
            fd_saveFile.Title = "另存字幕為...";
            fd_saveFile.FileName = fd_fileDialog.FileName;
            fd_saveFile.Filter = "字幕檔案(*.srt)|*.srt|任何檔案(*.*)|*.*";
            fd_saveFile.ShowDialog();
        }

        private void btn_retime_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txt_ms.Text, out timeDiff)) timeDiff = 0;

            if (timeDiff == 0) { 
                MessageBox.Show("轉換未執行，請輸入欲重新同步的毫秒數", "重新同步", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            long numDiff = 0;
            long.TryParse(txt_start.Text, out numDiff);

            string buffer = "";

            //開始讀取來源
            string[] source = txt_input.Text.Split(new string[1] {CRLF},StringSplitOptions.None);
            foreach (string line in source)
            {
                if (Regex.IsMatch(line, @"\d+:\d+:\d+,\d+ --> \d+:\d+:\d+,\d+"))
                {
                    //解析時間
                    Regex reg = new Regex(@"(\d+):(\d+):(\d+),(\d+) --> (\d+):(\d+):(\d+),(\d+)");
                    string[] arr = reg.Split(line);
                    //嘗試轉換時間
                    try
                    {
                        DateTime time1 = new DateTime(1, 1, 1, int.Parse(arr[1]), int.Parse(arr[2]), int.Parse(arr[3]), int.Parse(arr[4]));
                        DateTime time2 = new DateTime(1, 1, 1, int.Parse(arr[5]), int.Parse(arr[6]), int.Parse(arr[7]), int.Parse(arr[8]));
                        time1 = time1.AddMilliseconds(timeDiff);
                        time2 = time2.AddMilliseconds(timeDiff);
                        buffer += time1.ToString("HH:mm:ss,") + time1.Millisecond.ToString("000") + " --> " + time2.ToString("HH:mm:ss,") + time2.Millisecond.ToString("000") + CRLF;
                    }
                    catch
                    {
                        MessageBox.Show("重新同步時間時發生錯誤\n可能超出時間範圍。", "失敗");
                        return;
                    }
                }
                else if (Regex.IsMatch(line, @"^\d+$") && numDiff != 0)
                {
                    long num = 0;
                    long.TryParse(line, out num);

                    buffer += (num + numDiff).ToString() + CRLF;
                }
                //略過不是時間行
                else
                {
                    buffer += line + CRLF;
                }
            }
            //UI
            txt_output.Text = buffer;
            tab_preview.SelectTab(1);

            btn_saveFile.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.wretch.cc/blog/Lackneets"); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
