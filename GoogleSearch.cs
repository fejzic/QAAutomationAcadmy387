using Microsoft.Graph;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Threading;



namespace KursQAAutDzenana
{
    public class GoogleSearch
    {


        public static string SearchParameters(string word)
        {
            string message = " ";
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

                Function.TakeScreenshot();


            }
            catch (Exception e)
            {
                message += "ERROR !!" + e.Message;
            }
            return message;
        }

        

        public static string SearchCourse()
        {
            string message = " ";


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

                var acadamy387CourseLecturerOptionSelect = Driver.Instance.FindElement(By.CssSelector("#lecturer_id > option:nth-child(206)"));
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
                message += "ERROR!!" + e.Message;
            }
            return message;
        }

        public static string SignUpCourse()
        {
            string message = " ";
            string name = "Dzenana";



            try
            {
               
                var acadamy387CourseClickCourseSignUp = Driver.Instance.FindElement(By.LinkText("Prijavi se"));
                acadamy387CourseClickCourseSignUp.Click();

                Driver.Instance.SwitchTo().ActiveElement();

                Thread.Sleep(1000);

                var acadamy387CourseClickCourseSignUpName = Driver.Instance.FindElement(By.CssSelector("#name"));
                acadamy387CourseClickCourseSignUpName.SendKeys(name);
                Thread.Sleep(1000);

                var acadamy387CourseClickCourseSignUpEmail = Driver.Instance.FindElement(By.CssSelector("#email"));

                acadamy387CourseClickCourseSignUpEmail.SendKeys("myusername@gmail.com");
                Thread.Sleep(1000);

                var acadamy387CourseClickCourseSignUpAddress = Driver.Instance.FindElement(By.CssSelector("#address"));
                acadamy387CourseClickCourseSignUpAddress.SendKeys("Address");

                var acadamy387CourseClickCourseSignUpPhone = Driver.Instance.FindElement(By.CssSelector("#phone"));
                acadamy387CourseClickCourseSignUpPhone.SendKeys("387566");

                var acadamy387CourseClickCourseSignUpOrganization = Driver.Instance.FindElement(By.CssSelector("#organization"));
                acadamy387CourseClickCourseSignUpOrganization.SendKeys("Organization");

                var acadamy387CourseClickCourseSignUpNote = Driver.Instance.FindElement(By.CssSelector("#note"));
                acadamy387CourseClickCourseSignUpNote.SendKeys("I want to sign up");

               

                //new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(3)).Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.CssSelector("#rc-imageselect")));



                var acadamy387CourseClickCourseSignUpSubmit = Driver.Instance.FindElement(By.CssSelector("#program-signup-form > input.btn.btn-lg.btn-block.btn-green.btn-submit"));

                acadamy387CourseClickCourseSignUpSubmit.Click(); 





            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            return message;
        }

        public static string Lecturer(string lecturer)
        {
            string message = " ";

            try
            {
                var academy387Lecturer = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 .nav.navbar-nav.navbar-right li:nth-child(2)"));
                academy387Lecturer.Click();
                Thread.Sleep(1000);

                var academy387LecturerSearchByLetter = Driver.Instance.FindElement(By.CssSelector("div.page-content > div > section > div > div:nth-child(1) > div.col-xs-12.hidden-xs.hidden-sm > div > ul > li:nth-child(14) >a"));
                academy387LecturerSearchByLetter.Click();
                Thread.Sleep(1000);

                var academy387LecturerSearchByPhoto = Driver.Instance.FindElement(By.CssSelector("#lecturers-container > div > div:nth-child(9) > div > a > div.lecturer-image.text-center"));
                academy387LecturerSearchByPhoto.Click();
                Thread.Sleep(1000);

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

                Driver.Instance.Navigate().Back();

                var academy387LecturerSearchByName = Driver.Instance.FindElement(By.CssSelector("#lecturers-search"));
                academy387LecturerSearchByName.SendKeys(lecturer);

                Actions builder = new Actions(Driver.Instance);
                builder.SendKeys(Keys.Enter).Perform();
                Thread.Sleep(500);






            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            return message; 
        }

        public static string Event()
        {
            string message = " ";

            try
            {
                var academy387Event = Driver.Instance.FindElement(By.LinkText("Događaji"));
                academy387Event.Click();

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
                message += "Error" + e.Message;
            }
            return message;
        }

        public static string Contact(string lecturer)
        {
            string message = " ";

            try
            {
                var academy387Contact = Driver.Instance.FindElement(By.LinkText("Kontakt"));
                academy387Contact.Click();
                Thread.Sleep(1000);


                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.End);
                Thread.Sleep(1000);

                // Scroll down one view pane
                Driver.Instance.FindElement(By.TagName("body")).SendKeys(Keys.Control + Keys.PageDown);
                Thread.Sleep(1000);

                var academy387Payment = Driver.Instance.FindElement(By.LinkText("Upute za plaćanje"));
                academy387Payment.Click();
                Thread.Sleep(1000);

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

                var academy387SearchLecturer = Driver.Instance.FindElement(By.CssSelector("#main-search-input"));
                academy387SearchLecturer.SendKeys(lecturer);
                Thread.Sleep(1000);

                Actions builder = new Actions(Driver.Instance);
                builder.SendKeys(Keys.Enter).Perform();
                Thread.Sleep(500);


            }
            catch (Exception e)
            {
                message += "Error" + e.Message;
            }
            return message;
        }



        public static string Client()
        {
            string message = " ";

            try
            {
                var academy387Client = Driver.Instance.FindElement(By.LinkText("Klijenti"));
                academy387Client.Click();
                Thread.Sleep(1000);


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
                message += "ERROR" + e.Message;
            }
            return message;
        }

        public static string MainPage()
        {
            string message = "";

            try
            {
                var academy387Logo = Driver.Instance.FindElement(By.CssSelector("div > div.navbar-header > a"));
                academy387Logo.Click();
                Thread.Sleep(1000);

                var academy387SlidePicturesRight = Driver.Instance.FindElement(By.CssSelector("#bs-carousel > a.carousel-control.right"));
                for (int i=0; i<4; i++)
                {
                    academy387SlidePicturesRight.Click();
                    Thread.Sleep(1000);

                }

                var academy387SlidePicturesLeft = Driver.Instance.FindElement(By.CssSelector("#bs-carousel > a.carousel-control.left"));
                for (int i = 0; i < 4; i++)
                {
                    academy387SlidePicturesLeft.Click();
                    Thread.Sleep(1000);

                }

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
                Thread.Sleep(1000);


            }
            catch (Exception e)
            {
                message += "ERROR" + e.Message;
            }

            return message;
        }


    }
}


