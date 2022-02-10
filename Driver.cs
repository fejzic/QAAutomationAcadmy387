using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursQAAutDzenana
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            Instance = new ChromeDriver();
            

            Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));

            Instance.Manage().Window.Maximize();


        }

        public static void Initialize(int n)
        {
            if (n == 2)
            {
                var downloadDirectory = @"C:\Files";
                ChromeOptions option = new ChromeOptions();

                option.AddUserProfilePreference("download.default_directory", downloadDirectory);
                option.AddUserProfilePreference("download.prompt_for.download", false);
                option.AddUserProfilePreference("disable-popup-blocking", "true");
                option.AddUserProfilePreference("plugin.plugin_disable", new[] {
                "Adobe Flash Player",
                "Chrome PDF Viewer" });

                Instance = new ChromeDriver(@"C:\Drivers", option);
                Instance.Manage().Window.Maximize();



            }

        }

        public static void Close()
        {
            Instance.Close();
        }


    }
}
