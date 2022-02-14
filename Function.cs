using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursQAAutDzenana
{
    public  class Function
    {
        public static void WriteInto(string readText)
        {

            string filePath = @"C:\TestConfiguration\LogFile.txt";

            File.AppendAllText(filePath, readText + Environment.NewLine);

        }
    }
}
