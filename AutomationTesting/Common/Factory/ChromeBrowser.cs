using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTesting.Common.Factory;

public class ChromeBrowser : IBrowser
{
    public IWebDriver Create()
    {
        string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        IWebDriver driver = new ChromeDriver(path + "/resources/driver/chromedriver.exe");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        driver.Manage().Window.Maximize();
        return driver;
    }
}
