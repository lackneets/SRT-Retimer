namespace readerT_Retimer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fd_fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.tab_preview = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.fd_saveFile = new System.Windows.Forms.SaveFileDialog();
            this.btn_saveFile = new System.Windows.Forms.Button();
            this.btn_retime = new System.Windows.Forms.Button();
            this.txt_ms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txt_start = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_preview.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fd_fileDialog
            // 
            this.fd_fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fd_fileDialog_FileOk);
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(12, 12);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(73, 22);
            this.btn_openFile.TabIndex = 0;
            this.btn_openFile.Text = "開啟字幕";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // tab_preview
            // 
            this.tab_preview.Controls.Add(this.tabPage1);
            this.tab_preview.Controls.Add(this.tabPage2);
            this.tab_preview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tab_preview.Location = new System.Drawing.Point(0, 51);
            this.tab_preview.Name = "tab_preview";
            this.tab_preview.SelectedIndex = 0;
            this.tab_preview.Size = new System.Drawing.Size(644, 324);
            this.tab_preview.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_input);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "輸入預覽";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_input
            // 
            this.txt_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_input.Location = new System.Drawing.Point(3, 3);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.ReadOnly = true;
            this.txt_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_input.Size = new System.Drawing.Size(630, 292);
            this.txt_input.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_output);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "輸出預覽";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_output
            // 
            this.txt_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_output.Location = new System.Drawing.Point(3, 3);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_output.Size = new System.Drawing.Size(630, 292);
            this.txt_output.TabIndex = 2;
            // 
            // fd_saveFile
            // 
            this.fd_saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.fd_saveFile_FileOk);
            // 
            // btn_saveFile
            // 
            this.btn_saveFile.Enabled = false;
            this.btn_saveFile.Location = new System.Drawing.Point(91, 12);
            this.btn_saveFile.Name = "btn_saveFile";
            this.btn_saveFile.Size = new System.Drawing.Size(75, 22);
            this.btn_saveFile.TabIndex = 2;
            this.btn_saveFile.Text = "另存字幕";
            this.btn_saveFile.UseVisualStyleBackColor = true;
            this.btn_saveFile.Click += new System.EventHandler(this.btn_saveFile_Click);
            // 
            // btn_retime
            // 
            this.btn_retime.Enabled = false;
            this.btn_retime.Location = new System.Drawing.Point(172, 12);
            this.btn_retime.Name = "btn_retime";
            this.btn_retime.Size = new System.Drawing.Size(75, 22);
            this.btn_retime.TabIndex = 3;
            this.btn_retime.Text = "重新同步";
            this.btn_retime.UseVisualStyleBackColor = true;
            this.btn_retime.Click += new System.EventHandler(this.btn_retime_Click);
            // 
            // txt_ms
            // 
            this.txt_ms.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txt_ms.Location = new System.Drawing.Point(297, 12);
            this.txt_ms.MaxLength = 10;
            this.txt_ms.Name = "txt_ms";
            this.txt_ms.Size = new System.Drawing.Size(64, 22);
            this.txt_ms.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "毫秒";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveBorder;
            this.linkLabel1.Location = new System.Drawing.Point(552, 54);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 12);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "作者：Lackneets";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txt_start
            // 
            this.txt_start.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txt_start.Location = new System.Drawing.Point(502, 12);
            this.txt_start.MaxLength = 10;
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(64, 22);
            this.txt_start.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "編號開始於";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 375);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_start);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ms);
            this.Controls.Add(this.btn_retime);
            this.Controls.Add(this.btn_saveFile);
            this.Controls.Add(this.tab_preview);
            this.Controls.Add(this.btn_openFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SRT Resync 0.2";
            this.tab_preview.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fd_fileDialog;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.TabControl tab_preview;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.SaveFileDialog fd_saveFile;
        private System.Windows.Forms.Button btn_saveFile;
        private System.Windows.Forms.Button btn_retime;
        private System.Windows.Forms.TextBox txt_ms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txt_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

