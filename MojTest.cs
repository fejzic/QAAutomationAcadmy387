using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KursQAAutDzenana
{
    [TestClass]
    public class MojTest
    {

        [TestInitialize]

        public void Init()
        {

            TestArguments parametes  = new TestArguments();

            int a = int.Parse(parametes.browser);

            Driver.Initialize(a);

        }

        [TestMethod]
        public void TestMethod1()
        {
            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string pretraga = GoogleSearch.SearchParameters("Acadamy387");
            string pretragaKursa = GoogleSearch.SearchCourse();
            string pretragaKursaPrijava = GoogleSearch.SignUpCourse();
        }




      /* [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }*/
    }
}