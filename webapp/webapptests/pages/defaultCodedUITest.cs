using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CUITCommon.Abstracts;
using CUITCommon.Interfaces;
using CUITSeleniumProduct;

namespace webapptests.pages
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class defaultCodedUITest
    {

        private WebBrowser _browser;
        private IWebPage _pages;


        public defaultCodedUITest()
        {
        }

        [TestMethod]
        public void CodedUITestDefaultIrpara()
        {
            defaultpage page = _pages.Launch<defaultpage>(_browser, true, true);     
            Assert.IsTrue(page.IsAt());
            _pages.Unload(page);
        }

        [TestMethod]
        public void CodedUITestDefaultCarregarPagina()
        {
            defaultpage page = _pages.Launch<defaultpage>(_browser, true, true);
            Assert.IsTrue(page.IsValidPageDisplayed());
            _pages.Unload(page);
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
          _browser =  CUITFramework.Factories.FactoryObjects<SeleniumWebFactory>.FactoryBrowser("chrome");
          _pages   =  CUITFramework.Factories.FactoryObjects<SeleniumWebFactory>.FactoryPage();
          _pages.SetBaseURl("http://localhost/webapp");
        }

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
