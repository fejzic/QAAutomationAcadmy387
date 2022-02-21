using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace KursQAAutDzenana
{
    internal class PHPTravels
    {
        public static string SearchSite(string word)
        {
            string message = "";
            string name = "phptravels new opportunity";
            try
            {
                var findSite = Driver.Instance.FindElement(By.Name("q"));
                findSite.SendKeys(word);
                Thread.Sleep(500);

                Actions builder = new Actions(Driver.Instance);
                builder.SendKeys(Keys.Enter).Perform();
                Thread.Sleep(500);

                var phhTravels = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div > div > div > div.yuRUbf > a"));
                phhTravels.Click();

                var phpTravelsCompany = Driver.Instance.FindElement(By.CssSelector("body > header > div > nav > div.lvl-0.dropdown.headerLang"));
                phpTravelsCompany.Click();

                var phpTravelsComapanyBlog = Driver.Instance.FindElement(By.CssSelector("nav > div.lvl-0.dropdown.headerLang.open > div > a:nth-child(1)"));
                phpTravelsComapanyBlog.Click();

                var phpTravelsComapanyBlogSearchByNameClick = Driver.Instance.FindElement(By.CssSelector("body > section.hero > div > div > div:nth-child(2) > span > span.selection > span"));
                phpTravelsComapanyBlogSearchByNameClick.Click();
                var phpTravelsComapanyBlogSearchByName = Driver.Instance.FindElement(By.CssSelector("span.select2-search.select2-search--dropdown > input"));
                phpTravelsComapanyBlogSearchByName.SendKeys(name);

                var phpTravelsComapanyBlogSearchByNameClickOption = Driver.Instance.FindElement(By.CssSelector("body > span > span > span.select2-results"));
                phpTravelsComapanyBlogSearchByNameClickOption.Click();




            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;
            }
            return message;

            
        }
    }
}