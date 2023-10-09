using System.Configuration;

namespace BC.Resources
{
    static class ConfigSystem
    {
        static private string _titleSystem = "BC (Version 1.0.1)";
        static private string _nameFileLog = "LogBC.txt";

        
        static public string TitleSystem
        {
            get { return _titleSystem; }
            set { _titleSystem = value; }
        }

        static public string GetNameLog { get { return _nameFileLog;  } }

    }
}
