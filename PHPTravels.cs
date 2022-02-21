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
                Thread.Sleep(1000);


                var phpTravelsCompany = Driver.Instance.FindElement(By.CssSelector("body > header > div > nav > div.lvl-0.dropdown.headerLang"));
                phpTravelsCompany.Click();

                var phpTravelsComapanyBlog = Driver.Instance.FindElement(By.CssSelector("nav > div.lvl-0.dropdown.headerLang.open > div > a:nth-child(1)"));
                phpTravelsComapanyBlog.Click();
                Thread.Sleep(1000);


                var phpTravelsComapanyBlogSearchByNameClick = Driver.Instance.FindElement(By.CssSelector("body > section.hero > div > div > div:nth-child(2) > span > span.selection > span"));
                phpTravelsComapanyBlogSearchByNameClick.Click();
                Thread.Sleep(1000);

                var phpTravelsComapanyBlogSearchByName = Driver.Instance.FindElement(By.CssSelector("span.select2-search.select2-search--dropdown > input"));
                phpTravelsComapanyBlogSearchByName.SendKeys(name);
                Thread.Sleep(1000);

                var phpTravelsComapanyBlogSearchByNameClickOption = Driver.Instance.FindElement(By.CssSelector("body > span > span > span.select2-results"));
                phpTravelsComapanyBlogSearchByNameClickOption.Click();
                Thread.Sleep(3000);

                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.End);
                Thread.Sleep(1000);

                // Scroll to the top of the web page
                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.Home);
                Thread.Sleep(1000);

                // Scroll down one view pane
                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.PageDown);
                Thread.Sleep(1000);

                // Scroll up one view pane
                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.PageUp);

                Function.TakeScreenshot();


            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;
            }
            return message;

            
        }

        public static string TestCategoryTravel()
        {
            string message = "";

            try
            {
                var phpTravelsCompanyBlogCategory = Driver.Instance.FindElement(By.CssSelector("body > header > nav > div > div"));
                phpTravelsCompanyBlogCategory.Click();

                var phpTravelsCompanyBlogCategoryTravel = Driver.Instance.FindElement(By.CssSelector("body > header > nav > div > div > ul > li:nth-child(1) > a"));
                phpTravelsCompanyBlogCategoryTravel.Click();

                var phpTravelsCompanyBlogCategoryTravelHotel = Driver.Instance.FindElement(By.CssSelector("body > div.categories > div > div > div > div > div:nth-child(35) > a"));
                phpTravelsCompanyBlogCategoryTravelHotel.Click();

                Function.TakeScreenshot();


                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.End);
                Thread.Sleep(1000);

                // Scroll to the top of the web page
                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.Home);
                Thread.Sleep(1000);

                // Scroll down one view pane
                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.PageDown);
                Thread.Sleep(1000);

                // Scroll up one view pane
                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.PageUp);

                Thread.Sleep(3000);



            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;
            }

            return message;
        }


        public static string TestCategoryVersion()
        {
            string message = "";

            try
            {
                var phpTravelsCompanyBlogCategory = Driver.Instance.FindElement(By.CssSelector("body > header > nav > div > div"));
                phpTravelsCompanyBlogCategory.Click();

                var phpTravelsCompanyBlogCategoryVersion = Driver.Instance.FindElement(By.CssSelector("body > header > nav > div > div > ul > li:nth-child(2) > a"));
                phpTravelsCompanyBlogCategoryVersion.Click();

                var phpTravelsCompanyBlogCategoryVersionOption = Driver.Instance.FindElement(By.CssSelector("body > div > div > div > div > div > div:nth-child(1) > a"));
                phpTravelsCompanyBlogCategoryVersionOption.Click();

                Function.TakeScreenshot();


                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.End);
                Thread.Sleep(1000);

                // Scroll to the top of the web page
                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.Home);
                Thread.Sleep(1000);

                // Scroll down one view pane
                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.PageDown);
                Thread.Sleep(1000);

                // Scroll up one view pane
                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.PageUp);

                Thread.Sleep(3000);


            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;
            }

            return message;
        }

        public static string TestCategoryEvents()
        {
            string message = "";

            try
            {
                var phpTravelsCompanyBlogCategory = Driver.Instance.FindElement(By.CssSelector("body > header > nav > div > div"));
                phpTravelsCompanyBlogCategory.Click();

                

                var phpTravelsCompanyBlogCategoryVersionOption = Driver.Instance.FindElement(By.CssSelector("body > div > div > div > div > div > div:nth-child(1) > a"));
                phpTravelsCompanyBlogCategoryVersionOption.Click();

                Function.TakeScreenshot();


                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.End);
                Thread.Sleep(1000);

                // Scroll to the top of the web page
                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.Home);
                Thread.Sleep(1000);

                // Scroll down one view pane
                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.PageDown);
                Thread.Sleep(1000);

                // Scroll up one view pane
                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.PageUp);

                Thread.Sleep(3000);


            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;
            }

            return message;
        }
    }
}