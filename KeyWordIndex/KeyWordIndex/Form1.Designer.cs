namespace KeyWordIndex
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Run = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_SourceFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NewFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Find = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Replace = new System.Windows.Forms.TextBox();
            this.button_SoureFolder = new System.Windows.Forms.Button();
            this.button_NewFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_log = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Run
            // 
            this.button_Run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Run.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Run.Location = new System.Drawing.Point(403, 198);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(112, 23);
            this.button_Run.TabIndex = 1;
            this.button_Run.Text = "替换";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KeyWordIndex.Properties.Resources.Word;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "原始文件路径：";
            // 
            // textBox1_SourceFolder
            // 
            this.textBox1_SourceFolder.Location = new System.Drawing.Point(208, 19);
            this.textBox1_SourceFolder.Name = "textBox1_SourceFolder";
            this.textBox1_SourceFolder.Size = new System.Drawing.Size(271, 21);
            this.textBox1_SourceFolder.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "修改后文件路径：";
            // 
            // textBox_NewFolder
            // 
            this.textBox_NewFolder.Location = new System.Drawing.Point(208, 66);
            this.textBox_NewFolder.Name = "textBox_NewFolder";
            this.textBox_NewFolder.Size = new System.Drawing.Size(271, 21);
            this.textBox_NewFolder.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "查找:";
            // 
            // textBox_Find
            // 
            this.textBox_Find.Location = new System.Drawing.Point(26, 155);
            this.textBox_Find.Name = "textBox_Find";
            this.textBox_Find.Size = new System.Drawing.Size(228, 21);
            this.textBox_Find.TabIndex = 7;
            this.textBox_Find.Text = "[发明领域]：（关键词）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(260, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "=>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "替换为:";
            // 
            // textBox_Replace
            // 
            this.textBox_Replace.Location = new System.Drawing.Point(283, 154);
            this.textBox_Replace.Name = "textBox_Replace";
            this.textBox_Replace.Size = new System.Drawing.Size(232, 21);
            this.textBox_Replace.TabIndex = 10;
            this.textBox_Replace.Text = "[发明领域（关键词）]：";
            // 
            // button_SoureFolder
            // 
            this.button_SoureFolder.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SoureFolder.Location = new System.Drawing.Point(488, 18);
            this.button_SoureFolder.Name = "button_SoureFolder";
            this.button_SoureFolder.Size = new System.Drawing.Size(27, 23);
            this.button_SoureFolder.TabIndex = 11;
            this.button_SoureFolder.Text = "...";
            this.button_SoureFolder.UseVisualStyleBackColor = true;
            this.button_SoureFolder.Click += new System.EventHandler(this.button_SoureFolder_Click);
            // 
            // button_NewFolder
            // 
            this.button_NewFolder.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_NewFolder.Location = new System.Drawing.Point(488, 64);
            this.button_NewFolder.Name = "button_NewFolder";
            this.button_NewFolder.Size = new System.Drawing.Size(27, 23);
            this.button_NewFolder.TabIndex = 12;
            this.button_NewFolder.Text = "...";
            this.button_NewFolder.UseVisualStyleBackColor = true;
            this.button_NewFolder.Click += new System.EventHandler(this.button_NewFolder_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(551, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Ready...";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusLabel2.Text = "...";
            // 
            // button_log
            // 
            this.button_log.Location = new System.Drawing.Point(26, 198);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(75, 23);
            this.button_log.TabIndex = 14;
            this.button_log.Text = "查看日志";
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(297, 198);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(75, 23);
            this.button_Stop.TabIndex = 15;
            this.button_Stop.Text = "停止";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 262);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_NewFolder);
            this.Controls.Add(this.button_SoureFolder);
            this.Controls.Add(this.textBox_Replace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Find);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_NewFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_SourceFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字符替换(用于docx和doc格式...)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_SourceFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NewFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Find;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Replace;
        private System.Windows.Forms.Button button_SoureFolder;
        private System.Windows.Forms.Button button_NewFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.Button button_Stop;
    }
}

