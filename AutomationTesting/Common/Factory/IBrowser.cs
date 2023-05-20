using OpenQA.Selenium;

namespace AutomationTesting.Common.Factory;

public interface IBrowser
{
    IWebDriver Create();
}
