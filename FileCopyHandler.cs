using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testProject
{
    class FileCopyHandler
    {
        public event EventHandler UpdateValueEvent;
        public async void CopyAction(string[] sourcePathArray, string targetPath)
        {
            int cnt = sourcePathArray.Length;
            int i = 0;
            while (true)
            {
                string[] buffer = sourcePathArray[i].Split('\\');
                string fileName = buffer[buffer.Length - 1];
                UpdateValue("[" + DateTime.Now.ToString("hh:mm:ss") + "] " + sourcePathArray[i] + " 파일을 " + targetPath + " 복사 시작");
                //UpdateValue("[" + DateTime.Now.ToString("hh:mm:ss") + "] " + sourcePathArray[i+1] + " 파일을 " + targetPath + " 복사 시작");

                if (Copy(sourcePathArray[i], targetPath + fileName))
                    UpdateValue("[" + DateTime.Now.ToString("hh:mm:ss") + "] " + sourcePathArray[i++] + " 파일을 " + targetPath + " 복사 성공");
                else
                    UpdateValue("[" + DateTime.Now.ToString("hh:mm:ss") + "] " + sourcePathArray[i++] + " 파일을 " + targetPath + " 복사 실패");
                //if (Copy(sourcePathArray[i], targetPath))
                //    UpdateValue("[" + DateTime.Now.ToString("hh:mm:ss") + "] " + sourcePathArray[i++] + " 파일을 " + targetPath + " 복사 성공");
                //else
                //    UpdateValue("[" + DateTime.Now.ToString("hh:mm:ss") + "] " + sourcePathArray[i++] + " 파일을 " + targetPath + " 복사 실패");

                await Task.Delay(1000);

                if (i >= cnt)
                    break;
            }
        }

        private bool Copy(string sourcePath, string targetPath)
        {
            try
            {
                System.IO.File.Copy(sourcePath, targetPath, true);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void UpdateValue(string value)
        {
            if (UpdateValueEvent != null)
                UpdateValueEvent(value, null);
        }
    }
}
