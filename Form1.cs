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
    // https://www.youtube.com/watch?v=vrhIxBWSJ04 꼭 한번 보시고 거기에 맞춰서 전반적으로 정리 해주세요.
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

            string path = "C:\\Users\\office4\\Desktop\\temp\\jSon.txt"; // 최종 파일명 은 전부 소문자가 기본입니다. 

            if (File.Exists(path)) // 이런 함수는 LoadJson 내부에서 처리 해주는게 어떨까요?
            {
                LoadJson(path); // Load 성공 유무는 어떻게 알 수 있을가요?
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private int work(int count) // 함수명은 기본적으로 PascalCase 입니다. Work 라고는 하셨는데 함수명칭만 봐서는 이 함수가 뭘 하는지는 모릅니다.
        {
            Copy c = new Copy();

            for(int i = 0; i < count; i++) // <- 이 로직은 Copy 핸들러에서 리스트만 받아서 처리 하는게 좋지 않을 까요? list<T> 또는 Array, 또는 배열 사용법을 익혀 주세요
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
                pathTextBox0.Text = CopyPath;
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

        /// 이하 기능은
        /// SystemConfig, ProgramSettings등의 클래스 에서 관리하는 것이 좋습니다.
        /// PathSetting 클래스 정도가 적당 하겠네요.
        /// 
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

        private void LoadJson(string path)
        {
            using (StreamReader file = File.OpenText(path))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject json = (JObject)JToken.ReadFrom(reader);
                CopyPath = json.SelectToken("CopyPath").ToString();
                BackupPath = json.SelectToken("BackupPath").ToString();
                pathTextBox0.Text = CopyPath;
                pathTextBox1.Text = BackupPath;

                string fileText = json.SelectToken("FileList").ToString();
                string logText = json.SelectToken("LogList").ToString();

                string[] fileArray = fileText.Split(',');
                string[] logArray = logText.Split(',');

                for (int i = 0; i < fileArray.Length; i++)
                    lsbFileListBox.Items.Add(fileArray[i]);
                for (int i = 0; i < logArray.Length; i++)
                    lsbLogsListBox.Items.Add(logArray[i]);
            }
        }
    }
}
