using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTesting
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver _driver;

        [TestInitialize]
        public void OpenBrowser()
        {
            Console.WriteLine("setup");
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            _driver = new ChromeDriver(Path.Combine(path, "chromedriver.exe"));
            _driver.Navigate().GoToUrl("http://todo.ly");
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            Console.WriteLine("clean");
        }

        [TestMethod]
        public void VerifyTheLoginIsSuccessfulyV1()
        {
            // click login button
            _driver.FindElement(By.XPath("//img[@src=\"/Images/design/pagelogin.png\"]")).Click();
            // full email textbox
            _driver.FindElement(By.Id("ctl00_MainContent_LoginControl1_TextBoxEmail")).SendKeys("bootcamp2@mojix.com");
            // fill password textbox
            _driver.FindElement(By.Id("ctl00_MainContent_LoginControl1_TextBoxPassword")).SendKeys("123435");
            // click login button
            _driver.FindElement(By.Id("ctl00_MainContent_LoginControl1_ButtonLogin")).Click();
            // verify -> the logout button should be displayed

            Assert.IsTrue(_driver.FindElement(By.Id("ctl00_HeaderTopControl1_LinkButtonLogout")).Displayed, "ERROR !! the login was not successfully, review credentials please");
        }
    }
}