using Microsoft.Graph;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;



namespace KursQAAutDzenana
{
    public class GoogleSearch
    {


        public static string SearchParameters(string word)
        {
            string messege = " ";
            string qa = "qa";


            try
            {
                var findText = Driver.Instance.FindElement(By.Name("q"));
                findText.SendKeys(word);
                Thread.Sleep(500);

                Actions builder = new Actions(Driver.Instance);
                builder.SendKeys(Keys.Enter).Perform();
                Thread.Sleep(500);

                var acadamy387 = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div > div > div > div.yuRUbf > a > h3"));
                acadamy387.Click();
                Thread.Sleep(500);

                var acadamy387Search = Driver.Instance.FindElement(By.Id("main-search-input"));
                acadamy387Search.SendKeys(qa);
                Thread.Sleep(1000);

                builder.SendKeys(Keys.Enter).Perform();
                Thread.Sleep(500);


            }
            catch (Exception e)
            {
                messege += "ERROR !!" + e.Message;
            }
            return messege;
        }

        public static string SearchCourse()
        {
            string messege = " ";


            try
            {
                var acadamy387CourseCategory = Driver.Instance.FindElement(By.Id("category_id"));
                acadamy387CourseCategory.Click();
                Thread.Sleep(500);

                var acadamy387CourseCategoryOption = Driver.Instance.FindElement(By.CssSelector("#category_id > option:nth-child(2)"));
                acadamy387CourseCategoryOption.Click();
                Thread.Sleep(500);

                var acadamy387CourseLecturerOption = Driver.Instance.FindElement(By.Id("lecturer_id"));
                acadamy387CourseLecturerOption.Click();
                Thread.Sleep(500);

                var acadamy387CourseLecturerOptionSelect = Driver.Instance.FindElement(By.CssSelector("#lecturer_id > option:nth-child(205)"));
                acadamy387CourseLecturerOptionSelect.Click();
                Thread.Sleep(500);

                var acadamy387CourseLowwerPrice = Driver.Instance.FindElement(By.Id("price_min"));
                acadamy387CourseLowwerPrice.SendKeys("50");
                Thread.Sleep(500);

                var acadamy387CourseHigherPrice = Driver.Instance.FindElement(By.Id("price_max"));
                acadamy387CourseHigherPrice.SendKeys("500");
                Thread.Sleep(500);

                var acadamy387CourseSubmit = Driver.Instance.FindElement(By.CssSelector("body > div.page-content > div > div > div > div.col-xs-12.col-md-3.seach-filters-col > form > input.btn.btn-green.btn-block"));
                acadamy387CourseSubmit.Click();
                Thread.Sleep(500);

                var acadamy387CourseClickCourse = Driver.Instance.FindElement(By.CssSelector("body > div.page-content > div > div > div > div.col-xs-12.col-md-9 > div.row.programs-row > div"));
                acadamy387CourseClickCourse.Click();
                Thread.Sleep(500);



                // Scroll the end of the web page
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

            }
            catch (Exception e)
            {
                messege += "ERROR!!" + e.Message;
            }
            return messege;
        }

        public static string SignUpCourse()
        {
            string messege = " ";
            string name = "Dzenana";



            try
            {
               
                var acadamy387CourseClickCourseSignUp = Driver.Instance.FindElement(By.LinkText("Prijavi se"));
                acadamy387CourseClickCourseSignUp.Click();
                
                Alert alert_win = (Alert)Driver.Instance.SwitchTo().Alert();
                
                
                //string alerMessage = alert_win.;
                //System.Console.WriteLine(alerMessage);
                /*WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement confirmButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText("Prijavi se")));
               
                confirmButton.Click();

               /* WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5000));
                wait.Until(drv => IsAlertShown(driver));*/

                Thread.Sleep(1000);





                var acadamy387CourseClickCourseSignUpName = Driver.Instance.FindElement(By.CssSelector("#name"));
                acadamy387CourseClickCourseSignUpName.SendKeys(name);









            }
            catch (Exception e)
            {
                messege += "ERROR!!" + e.Message;
            }
            return messege;
        }
    }
}


