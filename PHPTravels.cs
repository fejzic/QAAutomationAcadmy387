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
                Driver.Instance.Navigate().Back();


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
                Thread.Sleep(1000);

                var phpTravelsCompanyBlogCategoryTravel = Driver.Instance.FindElement(By.CssSelector("body > header > nav > div > div > ul > li:nth-child(1) > a"));
                phpTravelsCompanyBlogCategoryTravel.Click();
                Thread.Sleep(1000);

                var phpTravelsCompanyBlogCategoryTravelHotel = Driver.Instance.FindElement(By.CssSelector("body > div.categories > div > div > div > div > div:nth-child(35) > a"));
                phpTravelsCompanyBlogCategoryTravelHotel.Click();
                Thread.Sleep(1000);

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

                for (int i = 0; i < 2; i++)
                {
                    Driver.Instance.Navigate().Back();
                }




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
                Thread.Sleep(1000);

                var phpTravelsCompanyBlogCategoryVersion = Driver.Instance.FindElement(By.CssSelector("body > header > nav > div > div > ul > li:nth-child(2) > a"));
                phpTravelsCompanyBlogCategoryVersion.Click();
                Thread.Sleep(1000);

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

                for (int i = 0; i < 2; i++)
                {
                    Driver.Instance.Navigate().Back();
                }


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
                Thread.Sleep(1000);

                var phpTravelsCompanyBlogCategoryEvent = Driver.Instance.FindElement(By.CssSelector("body > header > nav > div > div > ul > li:nth-child(3) > a"));
                phpTravelsCompanyBlogCategoryEvent.Click();
                Thread.Sleep(1000);

                var phpTravelsCompanyBlogCategoryEventOption = Driver.Instance.FindElement(By.CssSelector("body > div.categories > div > div > div > div > div:nth-child(1) > a"));
                phpTravelsCompanyBlogCategoryEventOption.Click();



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

                for (int i = 0; i < 2; i++)
                {
                    Driver.Instance.Navigate().Back();
                }

            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;
            }

            return message;
        }

        public static string TestCategoryOffers()
        {
            string message = "";

            try
            {
                var phpTravelsCompanyBlogCategory = Driver.Instance.FindElement(By.CssSelector("body > header > nav > div > div"));
                phpTravelsCompanyBlogCategory.Click();
                Thread.Sleep(1000);

                var phpTravelsCompanyBlogCategoryOffer = Driver.Instance.FindElement(By.CssSelector("body > header > nav > div > div > ul > li:nth-child(4) > a"));
                phpTravelsCompanyBlogCategoryOffer.Click();
                Thread.Sleep(1000);

                var phpTravelsCompanyBlogCategoryOffersOption = Driver.Instance.FindElement(By.CssSelector("body > div.categories > div > div > div > div > div:nth-child(1) > a"));
                phpTravelsCompanyBlogCategoryOffersOption.Click();



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

                //Driver.Instance.Navigate().Back();



            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;
            }

            return message;
        }

        public static string TestCategoryTechnology()
        {
            string message = "";

            try
            {
                var phpTravelsCompanyBlogCategory = Driver.Instance.FindElement(By.CssSelector("body > header > nav > div > div"));
                phpTravelsCompanyBlogCategory.Click();
                Thread.Sleep(1000);

                var phpTravelsCompanyBlogCategoryTechnology = Driver.Instance.FindElement(By.CssSelector("body > header > nav > div > div > ul > li:nth-child(5) > a"));
                phpTravelsCompanyBlogCategoryTechnology.Click();
                Thread.Sleep(1000);

                var phpTravelsCompanyBlogCategoryTechnologyOption = Driver.Instance.FindElement(By.CssSelector("body > div.categories > div > div > div > div > div:nth-child(3) > a"));
                phpTravelsCompanyBlogCategoryTechnologyOption.Click();

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

                var phpTravelsLogo = Driver.Instance.FindElement(By.CssSelector("body > header > nav > div > ul.fl > li.brand.waves-effect.waves-button > a"));
                phpTravelsLogo.Click();

            }
            catch (Exception e)
            {
                message += "ERROR!" + e.Message;
            }

            return message;
        }

        public static string TestCategoryBusiness()
        {
            string message = "";

            try
            {
                var phpTravelsCompanyBlogCategory = Driver.Instance.FindElement(By.CssSelector("body > header > nav > div > div"));
                phpTravelsCompanyBlogCategory.Click();
                Thread.Sleep(1000);

                var phpTravelsCompanyBlogCategoryBusiness = Driver.Instance.FindElement(By.CssSelector("body > header > nav > div > div > ul > li:nth-child(6) > a"));
                phpTravelsCompanyBlogCategory.Click();
                Thread.Sleep(1000);

                var phpTravelsCompanyBlogCategoryBusinessOption  = Driver.Instance.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div[3]/a"));
                phpTravelsCompanyBlogCategoryBusinessOption.Click();
                Thread.Sleep(2000);

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