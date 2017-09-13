using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordClassLibrary;

namespace KeyWordIndex
{
    public partial class Form1 : Form
    {
        private int total = 0;
        private int pass = 0;
        private int failure = 0;

        private String sourceFolder;
        private String newFolder;

        private String logFile = Path.Combine(Environment.CurrentDirectory, "log.txt");
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Initialize()
        {            
            if (File.Exists(logFile))
            {
                File.Delete(logFile);
            }
            File.AppendAllText(logFile, "---" + DateTime.Now.ToShortDateString() + "---\r\n");
            this.button_Stop.Enabled = false;

            this.backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            this.backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            this.backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
        }


        private void button_Run_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.textBox1_SourceFolder.Text)||
                String.IsNullOrEmpty(this.textBox_NewFolder.Text)||                
                String.IsNullOrEmpty(this.textBox_Find.Text)||
                String.IsNullOrEmpty(this.textBox_Replace.Text))
            {
                MessageBox.Show("请将输入框填写完整。");
                return;
            }

            sourceFolder = this.textBox1_SourceFolder.Text;
            if(!Directory.Exists(sourceFolder))
            {
                MessageBox.Show("源文件路径不存在，请确认！");
                return;
            }
            
            newFolder = this.textBox_NewFolder.Text;
            if (!Directory.Exists(newFolder))
                Directory.CreateDirectory(newFolder);

            //为了避免在后面的路径替换中/的干扰
            sourceFolder = (new DirectoryInfo(sourceFolder)).FullName;
            newFolder = (new DirectoryInfo(newFolder)).FullName;

            this.backgroundWorker1.RunWorkerAsync();
            this.toolStripStatusLabel1.Text = "Running...";
            this.button_Run.Enabled = false;
            this.button_Stop.Enabled = true;

            total = 0;
            pass = 0;
            failure = 0;
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                this.toolStripStatusLabel1.Text = "Stopped!";
            else if (e.Error != null)
                this.toolStripStatusLabel1.Text = "Error!";
            else
                this.toolStripStatusLabel1.Text = "Completed!";

            this.button_Run.Enabled = true;
            this.button_Stop.Enabled = false;
        }

        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.toolStripStatusLabel2.Text = String.Format("共有：{2}; 成功|失败：{0}|{1}", pass, failure, total);
            this.toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {            
            String findWord = this.textBox_Find.Text;
            String replaceWord = this.textBox_Replace.Text;
            
            List<FileInfo> sourceFiles = GetSourceFiles(new DirectoryInfo(sourceFolder));
            total = sourceFiles.Count;
            backgroundWorker1.ReportProgress(100 * (pass + failure) / total, null);
            ProcessWord pd = new ProcessWord();
            try
            {
                pd.OpenApplication();
                try
                {
                    foreach (FileInfo fileInfo in sourceFiles)
                    {
                        if (backgroundWorker1.CancellationPending)
                        { 
                            break;
                        }
                        try
                        {
                            pd.OpenDocument(fileInfo.FullName);
                            pd.Replace(findWord, replaceWord);
                            String parentDir = fileInfo.DirectoryName;
                            String newParentDir = parentDir.Replace(sourceFolder, newFolder);
                            if (!Directory.Exists(newParentDir))
                                Directory.CreateDirectory(newParentDir);
                            pd.SaveAsDocx(Path.Combine(newParentDir, fileInfo.Name));
                            pass++;
                        }
                        catch(Exception exp)
                        {
                            File.AppendAllText(logFile, String.Format("替换文件失败：{0}\r\n\t错误信息：{1}\r\n", fileInfo.FullName, exp.Message));
                            failure++;
                        }
                        finally
                        {
                            pd.CloseDocument();
                        }
                        backgroundWorker1.ReportProgress(100*(pass+failure)/total,null);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                pd.CloseDocument();
                pd.QuitApplication();
            }
            
        }

        private List<FileInfo> GetSourceFiles(DirectoryInfo sourceDirInfo)
        {
            List<FileInfo> list = new List<FileInfo>();
            FileInfo[] filesDocx = sourceDirInfo.GetFiles("*.docx", SearchOption.AllDirectories);
            FileInfo[] filesDoc = sourceDirInfo.GetFiles("*.doc", SearchOption.AllDirectories);
            if (filesDocx != null)
                list.AddRange(filesDocx.ToList());
            if (filesDoc != null)
                list.AddRange(filesDoc.ToList());            
            
            return list;            
        }

        

        private void button_SoureFolder_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1_SourceFolder.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void button_NewFolder_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox_NewFolder.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("关闭窗口？", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            System.Environment.Exit(0);
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(logFile);
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.CancelAsync();
            this.button_Stop.Enabled = false;
            this.button_Run.Enabled = true;
        }
    }
}
