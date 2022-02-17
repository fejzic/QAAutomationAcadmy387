using OpenQA.Selenium;
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

        public static void TakeScreenshot()
        {
            Random r = new Random();

            ((ITakesScreenshot)Driver.Instance).GetScreenshot().SaveAsFile("C:/Screenshot/" + "/Screenshot" + r.Next(0, 100000) + DateTime.Now.ToString("dd_MMMM_hh_mm_ss_tt") + "jpeg", ScreenshotImageFormat.Jpeg);
        }
    }
}
