using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace testProject
{
    class PathSetting
    {
        public class SettingValue
        {
            public string[] FilePathArray
            {
                get;set;
            }
            public string CopyPath
            {
                get; set;
            }
            public string BackupPath
            {
                get; set;
            }
        }

        string storagePath;
        public SettingValue ClassValue;
        public PathSetting(string path)
        {
            storagePath = path;
            ClassValue = new SettingValue();
        }

        public void SetValue(string[] filePathArray, string copyPath, string backupPath)
        {
            ClassValue.FilePathArray = filePathArray;
            ClassValue.CopyPath = copyPath;
            ClassValue.BackupPath = backupPath;
        }
        
        public void SaveJson()
        {
            string jsonString = JsonConvert.SerializeObject(ClassValue);
            File.WriteAllText(storagePath, jsonString);
        }

        public bool LoadJson()
        {
            if (File.Exists(storagePath))
            {
                string value = File.ReadAllText(storagePath);
                ClassValue = JsonConvert.DeserializeObject<SettingValue>(value);

                return true;
            }
            else
                return false;
        }
    }
}
