namespace testProject
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileSelectButton = new System.Windows.Forms.Button();
            this.pathDeleteButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lsbFileListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbLogsListBox = new System.Windows.Forms.ListBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.settingSaveButton = new System.Windows.Forms.Button();
            this.pathTextbox0 = new System.Windows.Forms.TextBox();
            this.pathTextBox1 = new System.Windows.Forms.TextBox();
            this.findPathButton0 = new System.Windows.Forms.Button();
            this.findPathButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileSelectButton
            // 
            this.FileSelectButton.Location = new System.Drawing.Point(12, 12);
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.Size = new System.Drawing.Size(132, 49);
            this.FileSelectButton.TabIndex = 0;
            this.FileSelectButton.Text = "파일 등록";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.Click += new System.EventHandler(this.button_Click);
            // 
            // pathDeleteButton
            // 
            this.pathDeleteButton.Location = new System.Drawing.Point(494, 12);
            this.pathDeleteButton.Name = "pathDeleteButton";
            this.pathDeleteButton.Size = new System.Drawing.Size(132, 49);
            this.pathDeleteButton.TabIndex = 1;
            this.pathDeleteButton.Text = "경로 삭제";
            this.pathDeleteButton.UseVisualStyleBackColor = true;
            this.pathDeleteButton.Click += new System.EventHandler(this.pathDeleteButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 484);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(848, 12);
            this.progressBar1.TabIndex = 2;
            // 
            // lsbFileListBox
            // 
            this.lsbFileListBox.FormattingEnabled = true;
            this.lsbFileListBox.ItemHeight = 12;
            this.lsbFileListBox.Location = new System.Drawing.Point(12, 67);
            this.lsbFileListBox.Name = "lsbFileListBox";
            this.lsbFileListBox.Size = new System.Drawing.Size(848, 148);
            this.lsbFileListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "대상 폴더";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "백업 폴더";
            // 
            // lsbLogsListBox
            // 
            this.lsbLogsListBox.FormattingEnabled = true;
            this.lsbLogsListBox.ItemHeight = 12;
            this.lsbLogsListBox.Location = new System.Drawing.Point(12, 329);
            this.lsbLogsListBox.Name = "lsbLogsListBox";
            this.lsbLogsListBox.Size = new System.Drawing.Size(848, 148);
            this.lsbLogsListBox.TabIndex = 8;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(494, 274);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(132, 49);
            this.copyButton.TabIndex = 7;
            this.copyButton.Text = "파일 카피 시작";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // settingSaveButton
            // 
            this.settingSaveButton.Location = new System.Drawing.Point(12, 274);
            this.settingSaveButton.Name = "settingSaveButton";
            this.settingSaveButton.Size = new System.Drawing.Size(132, 49);
            this.settingSaveButton.TabIndex = 6;
            this.settingSaveButton.Text = "설정 기억";
            this.settingSaveButton.UseVisualStyleBackColor = true;
            this.settingSaveButton.Click += new System.EventHandler(this.settingSaveButton_Click);
            // 
            // pathTextbox0
            // 
            this.pathTextbox0.Location = new System.Drawing.Point(75, 220);
            this.pathTextbox0.Name = "pathTextbox0";
            this.pathTextbox0.ReadOnly = true;
            this.pathTextbox0.Size = new System.Drawing.Size(494, 21);
            this.pathTextbox0.TabIndex = 9;
            // 
            // pathTextBox1
            // 
            this.pathTextBox1.Location = new System.Drawing.Point(75, 246);
            this.pathTextBox1.Name = "pathTextBox1";
            this.pathTextBox1.ReadOnly = true;
            this.pathTextBox1.Size = new System.Drawing.Size(494, 21);
            this.pathTextBox1.TabIndex = 10;
            // 
            // findPathButton0
            // 
            this.findPathButton0.Location = new System.Drawing.Point(575, 220);
            this.findPathButton0.Name = "findPathButton0";
            this.findPathButton0.Size = new System.Drawing.Size(51, 23);
            this.findPathButton0.TabIndex = 11;
            this.findPathButton0.Text = "_";
            this.findPathButton0.UseVisualStyleBackColor = true;
            this.findPathButton0.Click += new System.EventHandler(this.findPathButton0_Click);
            // 
            // findPathButton1
            // 
            this.findPathButton1.Location = new System.Drawing.Point(575, 245);
            this.findPathButton1.Name = "findPathButton1";
            this.findPathButton1.Size = new System.Drawing.Size(51, 23);
            this.findPathButton1.TabIndex = 12;
            this.findPathButton1.Text = "_";
            this.findPathButton1.UseVisualStyleBackColor = true;
            this.findPathButton1.Click += new System.EventHandler(this.findPathButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 507);
            this.Controls.Add(this.findPathButton1);
            this.Controls.Add(this.findPathButton0);
            this.Controls.Add(this.pathTextBox1);
            this.Controls.Add(this.pathTextbox0);
            this.Controls.Add(this.lsbLogsListBox);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.settingSaveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbFileListBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pathDeleteButton);
            this.Controls.Add(this.FileSelectButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "파일 복사기";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileSelectButton;
        private System.Windows.Forms.Button pathDeleteButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox lsbFileListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbLogsListBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button settingSaveButton;
        private System.Windows.Forms.TextBox pathTextbox0;
        private System.Windows.Forms.TextBox pathTextBox1;
        private System.Windows.Forms.Button findPathButton0;
        private System.Windows.Forms.Button findPathButton1;
    }
}

