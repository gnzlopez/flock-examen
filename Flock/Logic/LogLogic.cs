using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Flock.Logic
{
    public static class LogLogic
    {
        public static String FilePath { get; set; }

        static LogLogic()
        {
            FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt");;
        }

        public static void Log(String message)
        {
            using (StreamWriter file = File.AppendText(FilePath))
            {
                file.WriteLine($"{message} {DateTime.Now}");
            }
        }
    }
}