using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursQAAutDzenana
{
    [TestClass]
    public  class MojTest2
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

            string messagePHPTravel = PHPTravels.SearchSite("phptravels");
            string categoryPHPTravelsTravel = PHPTravels.TestCategoryTravel();
            string categoryPHPTravelsVersion = PHPTravels.TestCategoryVersion();
            string categoryPHPTravelsEvent = PHPTravels.TestCategoryEvents();
            string categoryPHPTravelsOffers = PHPTravels.TestCategoryOffers();
            string categoryPHPTravelsTechnology = PHPTravels.TestCategoryTechnology();
            string categoryPHPTravelsBusiness = PHPTravels.TestCategoryBusiness();
                

            if (!messagePHPTravel.Contains("ERROR") && !categoryPHPTravelsTravel.Contains("ERROR") && !categoryPHPTravelsEvent.Contains("ERROR") && !categoryPHPTravelsOffers.Contains("ERROR") && !categoryPHPTravelsTechnology.Contains("ERROR") && !categoryPHPTravelsBusiness.Contains("ERROR"))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + messagePHPTravel + categoryPHPTravelsTravel + categoryPHPTravelsVersion + categoryPHPTravelsEvent 
                    + categoryPHPTravelsOffers + categoryPHPTravelsTechnology + categoryPHPTravelsBusiness;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = "Test je prošao" + "\n" + messagePHPTravel + categoryPHPTravelsTravel + categoryPHPTravelsVersion + categoryPHPTravelsEvent
                    + categoryPHPTravelsOffers + categoryPHPTravelsTechnology + categoryPHPTravelsBusiness;
            }


            Assert.IsTrue(subject.Contains("Passed"));
            Assert.IsFalse(subject.Contains("Failed"));

            Function.WriteInto("Test ended" + DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt)"));
        }

        /*[TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }*/
    }

}
