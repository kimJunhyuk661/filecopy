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
        public SettingValue settingValue;
        public PathSetting(string path)
        {
            storagePath = path;
            settingValue = new SettingValue();
        }

        public void setValue(string[] filePathArray, string copyPath, string backupPath)
        {
            settingValue.FilePathArray = filePathArray;
            settingValue.CopyPath = copyPath;
            settingValue.BackupPath = backupPath;
        }
        
        public void SaveJson()
        {
            string jsonString = JsonConvert.SerializeObject(settingValue);
            File.WriteAllText(storagePath, jsonString);
        }

        public bool LoadJson()
        {
            if (File.Exists(storagePath))
            {
                using (StreamReader file = File.OpenText(storagePath))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject json = (JObject)JToken.ReadFrom(reader);
                    //settingValue = JsonConvert.DeserializeObject(;
                }

                return true;
            }
            else
                return false;
        }
    }
}
