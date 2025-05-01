using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects
{
    public static class AppData
    {

        public static string DataPath { get; set; }

        private static string _savePath = string.Empty;

        public static string SavePath
        {
            get
            {
                return _savePath;
            }
            set
            {
                _savePath = value;
            }
        }

    }
}
