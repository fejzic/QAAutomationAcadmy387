using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
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


        public static string SendEmailAttachment(string subject, string body)
        {
            string message = "",
                username = "dzenana.fejzic@gmail.com",
                password = "halapaca66?";


            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("dzenana.fejzic@gmail.com");
                mail.To.Add("dzenana.fejzic@gmail.com");
                mail.Subject = subject;
                mail.Body = body;

                System.Net.Mail.Attachment attachment;

                DirectoryInfo d = new DirectoryInfo(@"C:/Screenshot/");
                FileInfo[] Files = d.GetFiles("*", SearchOption.AllDirectories);

                foreach (FileInfo file in Files)
                {
                    attachment = new System.Net.Mail.Attachment(file.FullName);
                    mail.Attachments.Add(attachment);
                }

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                mail.Dispose();

            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            return message;
        }

        public static void TakeScreenshot()
        {
            Random r = new Random();

            ((ITakesScreenshot)Driver.Instance).GetScreenshot().SaveAsFile("C:/Screenshot/" + "/Screenshot" + r.Next(0, 100000) + DateTime.Now.ToString("dd_MMMM_hh_mm_ss_tt") + "jpeg", ScreenshotImageFormat.Jpeg);
        }
    }
}
