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
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.btnFileDelete = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lstFileList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstLogList = new System.Windows.Forms.ListBox();
            this.btnFileCopy = new System.Windows.Forms.Button();
            this.btnSettingSave = new System.Windows.Forms.Button();
            this.txtTargetPath = new System.Windows.Forms.TextBox();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.btnFineTargetPath = new System.Windows.Forms.Button();
            this.btnFindBackupPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.Location = new System.Drawing.Point(12, 12);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(132, 49);
            this.btnFileSelect.TabIndex = 0;
            this.btnFileSelect.Text = "파일 등록";
            this.btnFileSelect.UseVisualStyleBackColor = true;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // btnFileDelete
            // 
            this.btnFileDelete.Location = new System.Drawing.Point(494, 12);
            this.btnFileDelete.Name = "btnFileDelete";
            this.btnFileDelete.Size = new System.Drawing.Size(132, 49);
            this.btnFileDelete.TabIndex = 1;
            this.btnFileDelete.Text = "경로 삭제";
            this.btnFileDelete.UseVisualStyleBackColor = true;
            this.btnFileDelete.Click += new System.EventHandler(this.btnFileDelete_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 484);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(848, 12);
            this.progressBar1.TabIndex = 2;
            // 
            // lstFileList
            // 
            this.lstFileList.FormattingEnabled = true;
            this.lstFileList.ItemHeight = 12;
            this.lstFileList.Location = new System.Drawing.Point(12, 67);
            this.lstFileList.Name = "lstFileList";
            this.lstFileList.Size = new System.Drawing.Size(848, 148);
            this.lstFileList.TabIndex = 3;
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
            // lstLogList
            // 
            this.lstLogList.FormattingEnabled = true;
            this.lstLogList.ItemHeight = 12;
            this.lstLogList.Location = new System.Drawing.Point(12, 329);
            this.lstLogList.Name = "lstLogList";
            this.lstLogList.Size = new System.Drawing.Size(848, 148);
            this.lstLogList.TabIndex = 8;
            // 
            // btnFileCopy
            // 
            this.btnFileCopy.Location = new System.Drawing.Point(494, 274);
            this.btnFileCopy.Name = "btnFileCopy";
            this.btnFileCopy.Size = new System.Drawing.Size(132, 49);
            this.btnFileCopy.TabIndex = 7;
            this.btnFileCopy.Text = "파일 카피 시작";
            this.btnFileCopy.UseVisualStyleBackColor = true;
            this.btnFileCopy.Click += new System.EventHandler(this.btnFileCopy_Click);
            // 
            // btnSettingSave
            // 
            this.btnSettingSave.Location = new System.Drawing.Point(12, 274);
            this.btnSettingSave.Name = "btnSettingSave";
            this.btnSettingSave.Size = new System.Drawing.Size(132, 49);
            this.btnSettingSave.TabIndex = 6;
            this.btnSettingSave.Text = "설정 기억";
            this.btnSettingSave.UseVisualStyleBackColor = true;
            this.btnSettingSave.Click += new System.EventHandler(this.btnSettingSave_Click);
            // 
            // txtTargetPath
            // 
            this.txtTargetPath.Location = new System.Drawing.Point(75, 220);
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.ReadOnly = true;
            this.txtTargetPath.Size = new System.Drawing.Size(494, 21);
            this.txtTargetPath.TabIndex = 9;
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(75, 246);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.ReadOnly = true;
            this.txtBackupPath.Size = new System.Drawing.Size(494, 21);
            this.txtBackupPath.TabIndex = 10;
            // 
            // btnFineTargetPath
            // 
            this.btnFineTargetPath.Location = new System.Drawing.Point(575, 220);
            this.btnFineTargetPath.Name = "btnFineTargetPath";
            this.btnFineTargetPath.Size = new System.Drawing.Size(51, 23);
            this.btnFineTargetPath.TabIndex = 11;
            this.btnFineTargetPath.Text = "_";
            this.btnFineTargetPath.UseVisualStyleBackColor = true;
            this.btnFineTargetPath.Click += new System.EventHandler(this.btnFindTargetPath_Click);
            // 
            // btnFindBackupPath
            // 
            this.btnFindBackupPath.Location = new System.Drawing.Point(575, 245);
            this.btnFindBackupPath.Name = "btnFindBackupPath";
            this.btnFindBackupPath.Size = new System.Drawing.Size(51, 23);
            this.btnFindBackupPath.TabIndex = 12;
            this.btnFindBackupPath.Text = "_";
            this.btnFindBackupPath.UseVisualStyleBackColor = true;
            this.btnFindBackupPath.Click += new System.EventHandler(this.btnFindBackupPath_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 507);
            this.Controls.Add(this.btnFindBackupPath);
            this.Controls.Add(this.btnFineTargetPath);
            this.Controls.Add(this.txtBackupPath);
            this.Controls.Add(this.txtTargetPath);
            this.Controls.Add(this.lstLogList);
            this.Controls.Add(this.btnFileCopy);
            this.Controls.Add(this.btnSettingSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFileList);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnFileDelete);
            this.Controls.Add(this.btnFileSelect);
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

        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.Button btnFileDelete;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox lstFileList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstLogList;
        private System.Windows.Forms.Button btnFileCopy;
        private System.Windows.Forms.Button btnSettingSave;
        private System.Windows.Forms.TextBox txtTargetPath;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Button btnFineTargetPath;
        private System.Windows.Forms.Button btnFindBackupPath;
    }
}

