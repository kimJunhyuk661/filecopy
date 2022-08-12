using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace testProject
{
    // https://www.youtube.com/watch?v=vrhIxBWSJ04 꼭 한번 보시고 거기에 맞춰서 전반적으로 정리 해주세요.
    public partial class MainForm : Form
    {
        PathSetting pathSetting;

        public MainForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;

            pathSetting = new PathSetting("C:\\Users\\office4\\Desktop\\temp\\json.txt"); // 최종 파일명 은 전부 소문자가 기본입니다. // 파일명 -> Json -> json
            if (pathSetting.LoadJson())
            {
                lstFileList.Items.AddRange(pathSetting.ClassValue.FilePathArray);
                txtTargetPath.Text = pathSetting.ClassValue.CopyPath;
                txtBackupPath.Text = pathSetting.ClassValue.BackupPath;
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Copy() // 함수명은 기본적으로 PascalCase 입니다. Work 라고는 하셨는데 함수명칭만 봐서는 이 함수가 뭘 하는지는 모릅니다. // 함수명 work -> Copy
        {
            string[] filePathArray = lstFileList.Items.OfType<string>().ToArray();
            string copyPath = txtTargetPath.Text;

            FileCopyHandler fileCopy = new FileCopyHandler();
            fileCopy.UpdateValueEvent += this.UpdateFileList;
            Task.Factory.StartNew(() => fileCopy.CopyAction(filePathArray, copyPath));
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\Users\\office4\\Desktop\\temp";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (String filePath in ofd.FileNames)
                    lstFileList.Items.Add(filePath.ToString());
            }
            pathSetting.SetValue(lstFileList.Items.OfType<string>().ToArray(), txtTargetPath.Text, txtBackupPath.Text);
        }

        private void btnFileDelete_Click(object sender, EventArgs e)
        {
            if (lstFileList.SelectedIndex > -1)
                lstFileList.Items.RemoveAt(lstFileList.SelectedIndex);
        }

        private void btnSettingSave_Click(object sender, EventArgs e)
        {
            pathSetting.SaveJson();
        }

        private async void btnFileCopy_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = lstFileList.Items.Count;

            Copy();
        }

        private void btnFindTargetPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                pathSetting.ClassValue.CopyPath = fbd.SelectedPath;
                txtTargetPath.Text = fbd.SelectedPath;
            }
        }

        private void btnFindBackupPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                pathSetting.ClassValue.BackupPath = fbd.SelectedPath;
                txtBackupPath.Text = fbd.SelectedPath;
            }
        }

        private void UpdateFileList(object sender, EventArgs e)
        {
            lstLogList.Items.Add(sender.ToString());
        }
    }
}
