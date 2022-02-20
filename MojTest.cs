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
            string subject = "",
                    body = "";
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
            string glavniProzor = GoogleSearch.MainPage();


            if (!pretraga.Contains("ERROR") && !pretragaKursa.Contains("ERROR") && !predavac.Contains("ERROR") && !dogadjaj.Contains("ERROR") && !klijent.Contains("ERROR") && !kontakt.Contains("ERROR") && !pretragaKursaPrijava.Contains("ERROR") && !glavniProzor.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + pretraga + pretragaKursa + predavac + dogadjaj + klijent + pretragaKursaPrijava + kontakt + glavniProzor ;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = "Test je prošao" + "\n" + pretraga + pretragaKursa + predavac + dogadjaj + klijent + pretragaKursaPrijava + kontakt + glavniProzor;

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
