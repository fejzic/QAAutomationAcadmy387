using System.Threading;

namespace KursQAAutDzenana
{
    public class OpenUrl
    {

        public static void GoTo(string url)
        {
            Driver.Instance.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
        }
    }
}