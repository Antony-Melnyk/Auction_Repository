using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Logger
    {
        private static string LogPath = @"C:\Users\Admin\Desktop\NW\log.txt";
        public static void Log(string message)
        {
            using (StreamWriter sw = new StreamWriter(LogPath, true))
            {
                sw.WriteLine(DateTime.Now.ToString() + ": " + message);
            }
        }
    }
}
