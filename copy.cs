using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject
{
    public class Copy // 클래스 명은 함수 명 또는 명령어로 작성 하지 않는 것이 원칙 입니다. FileCopyHandler, FileMoveHelper, FileCoppier등의 명칭이 좋지 않을가요?
    {
        public string temp(string source_path, string target_path) // 함수명에는 Temp라는 임시적인 용어를 사용 하지 말아야 합니다. CopyFiles, CopyAction 등등의 용어를 쓰는게 좋지 않을까요?
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
