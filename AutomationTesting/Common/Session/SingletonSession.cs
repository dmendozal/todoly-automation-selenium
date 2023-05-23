using AutomationTesting.Common.Factory;
using OpenQA.Selenium;

namespace AutomationTesting.Common.Session;

public class SingletonSession
{
    /// <summary>
    /// Class instance
    /// </summary>
    private static SingletonSession? _instance = null;
    private readonly IWebDriver _browser;

    /// <summary>
    /// Private constructor
    /// </summary>
    private SingletonSession()
    {
        _browser = BrowserFactory.Make("grid").Create();
    }


    /// <summary>
    /// Static method to use in global way.
    /// </summary>
    /// <returns></returns>
    public static SingletonSession Instance()
    {
        _instance ??= new SingletonSession();

        return _instance;
    }

    public void CloseBrowser()
    {
        _instance = null;
        _browser.Quit();
    }


    public IWebDriver GetBrowser()
    {
        return _browser;
    }
}
