using IniParser;
using IniParser.Model;
using System;
using System.IO;

namespace OpenFusion_Server_Configurator.Definition.Model
{
    public abstract class Settings
    {
        protected string settingsFile;
        protected FileIniDataParser iniParser;
        protected IniData iniData;

        public Settings()
        {
        }

        protected virtual void initialize()
        {
            iniParser = new FileIniDataParser();
            iniData = new IniData();
        }

        public virtual bool LoadFile(string file)
        {
            if (File.Exists(file))
            {
                initialize();
                settingsFile = file;
                iniData = iniParser.ReadFile(file);
                ReadSettingsFile();
                return true;
            }
            return false;
        }

        public bool SaveFile()
        {
            if (!string.IsNullOrEmpty(settingsFile) && File.Exists(settingsFile))
            {
                SaveSettingsFile();
                iniParser.WriteFile(settingsFile, iniData);
                return true;
            }
            return false;
        }

        public T GetValue<T>(string section, string key)
        {
            string value = iniData[section][key];
            return (T)Convert.ChangeType(value, typeof(T));
        }

        public void SetValue<T>(string section, string key, T value)
        {
            iniData.SetValue(section, key, value);
        }

        public abstract void ReadSettingsFile();
        public abstract void SaveSettingsFile();
    }
}
