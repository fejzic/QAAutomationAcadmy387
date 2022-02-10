using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            string qa = "qa";

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

            }
            catch (Exception e)
            {
                messege += "ERROR!!" + e.Message;
            }
            return messege;

        }
    }
}

