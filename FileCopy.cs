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
        public async void CopyAction(string[] sourcePathArray, string targetPath, ListBox lst)
        {
            int cnt = sourcePathArray.Length;
            int i = 0;
            while (true)
            {
                lst.Items.Add("[" + DateTime.Now.ToString("hh:mm:ss") + "] " + sourcePathArray[i] + " 파일을 " + targetPath + " 복사 시작");
                lst.Items.Add("[" + DateTime.Now.ToString("hh:mm:ss") + "] " + sourcePathArray[i+1] + " 파일을 " + targetPath + " 복사 시작");

                if (Copy(sourcePathArray[i], targetPath))
                    lst.Items.Add("[" + DateTime.Now.ToString("hh:mm:ss") + "] " + sourcePathArray[i++] + " 파일을 " + targetPath + " 복사 성공");
                else
                    lst.Items.Add("[" + DateTime.Now.ToString("hh:mm:ss") + "] " + sourcePathArray[i++] + " 파일을 " + targetPath + " 복사 실패");
                if (Copy(sourcePathArray[i], targetPath))
                    lst.Items.Add("[" + DateTime.Now.ToString("hh:mm:ss") + "] " + sourcePathArray[i++] + " 파일을 " + targetPath + " 복사 성공");
                else
                    lst.Items.Add("[" + DateTime.Now.ToString("hh:mm:ss") + "] " + sourcePathArray[i++] + " 파일을 " + targetPath + " 복사 실패");

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
    }
}
