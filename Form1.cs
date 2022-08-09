using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace testProject
{
    public partial class MainForm : Form
    {
        string CopyPath;
        string BackupPath;

        public MainForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;

            string path = "C:\\Users\\office4\\Desktop\\temp\\jSon.txt";

            if (File.Exists(path))
            {
                InputJson(path + "");
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private int work(int count)
        {
            Copy c = new Copy();

            for(int i = 0; i < count; i++)
            {
                string source_path = lsbFileListBox.Items[i].ToString();

                string[] buffer = source_path.Split('\\');
                string target_path = CopyPath + "\\" + buffer[buffer.Length - 1];

                lsbLogsListBox.Items.Add("[" + DateTime.Now.ToString("hh:mm:ss") + "] " + source_path + " 파일을 " + target_path + " 복사 시작");
                lsbLogsListBox.Items.Add(c.temp(source_path, target_path));
                progressBar1.Value = i + 1;
                
                if (i % 2 == 1)
                    Thread.Sleep(1000);
            }

            Thread.Sleep(500);
            
            return count;
        }

        private void button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\Users\\office4\\Desktop\\temp";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (String filePath in ofd.FileNames)
                    lsbFileListBox.Items.Add(filePath.ToString());
            }
        }

        private void pathDeleteButton_Click(object sender, EventArgs e)
        {
            if (lsbFileListBox.SelectedIndex > -1)
                lsbFileListBox.Items.RemoveAt(lsbFileListBox.SelectedIndex);
            else
                MessageBox.Show("Pleas Select path");
        }

        private void settingSaveButton_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\office4\\Desktop\\temp";

            if (!File.Exists(path))
            {
                InputJson(path + "\\jSon.txt");
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = lsbFileListBox.Items.Count;

            Task<int> t = Task.Run(() => work(lsbFileListBox.Items.Count));
        }

        private void findPathButton0_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                CopyPath = fbd.SelectedPath;
                pathTextbox0.Text = CopyPath;
            }
        }

        private void findPathButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                BackupPath = fbd.SelectedPath;
                pathTextBox1.Text = BackupPath;
            }
        }

        public class Data
        {
            public string CopyPath = "";
            public string BackupPath = "";
            public string FileList = "";
            public string LogList = "";
        }
        private void InputJson(string path)
        {
            JObject jObject = new JObject(
                new JProperty("CopyPath", CopyPath),
                new JProperty("BackupPath", BackupPath)
                //new JProperty("")
                );
            jObject.Add("FileList", JArray.FromObject(lsbFileListBox.Items));
            jObject.Add("LogList", JArray.FromObject(lsbLogsListBox.Items));

            File.WriteAllText(path, jObject.ToString());
        }
    }
}
