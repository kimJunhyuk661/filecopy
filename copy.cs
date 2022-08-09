using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject
{
    public class copy
    {
        public string temp(string source_path, string target_path)
        {
            string value;

            try
            {
                System.IO.File.Copy(source_path, target_path, true);

                value = "[" + DateTime.Now.ToString("hh:mm:ss") + "] " + source_path + " 파일을 " + target_path + " 복사 성공";
            }
            catch
            {
                value = "[" + DateTime.Now.ToString("hh:mm:ss") + "] " + source_path + " 파일을 " + target_path + " 복사 실패";
            }

            return value;
        }
    }
}
