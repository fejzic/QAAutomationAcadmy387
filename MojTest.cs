using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KursQAAutDzenana
{
    [TestClass]
    public class MojTest
    {

        [TestInitialize]

        public void Init()
        {
            Function.WriteInto("Start of init");
            TestArguments parametes = new TestArguments();

            int a = int.Parse(parametes.browser);

            Driver.Initialize(a);

            Function.WriteInto("End of init");
        }

        [TestMethod]
        public void TestMethod1()
        {
            var subject = "Moj test";
            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string pretraga = GoogleSearch.SearchParameters("Academy387");
            string pretragaKursa = GoogleSearch.SearchCourse();
            string pretragaKursaPrijava = GoogleSearch.SignUpCourse();
            string predavac = GoogleSearch.Lecturer("Nemanja Pušara");
            string dogadjaj = GoogleSearch.Event();
            string klijent = GoogleSearch.Client();
            string kontakt = GoogleSearch.Contact("Nemanja Pušara");


            if (!pretraga.Contains("ERROR!") && !predavac.Contains("ERROR") /*&& !dogadjaj.Contains("ERROR") && !klijent.Contains("ERROR") && !kontakt.Contains("ERROR")*/)
            {
                subject = "Passed!!" + subject;
                Console.Write(subject);
            }
            else
            {
                subject = "Faild!!" + subject;
               
            }

            Assert.IsTrue(subject.Contains("Passed"));
            Assert.IsFalse(subject.Contains("Failed"));

            Function.WriteInto("Test ended" + DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt)"));
        }

        /*[TestMethod]
         public void TestMethod2()
         {
            
            var subject = "Passed";


            
            Assert.IsTrue(subject.Contains("Passed"));
            Assert.IsFalse(subject.Contains("Failed"));
        */




         [TestCleanup]
          public void Cleanup()
          {
              Driver.Close();
          }

    }
}
