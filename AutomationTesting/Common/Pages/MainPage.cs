using AutomationTesting.Common.Controls;
using OpenQA.Selenium;

namespace AutomationTesting.Common.Pages;

public class MainPage
{
    public Button loginButton = new(By.XPath("//img[@src=\"/Images/design/pagelogin.png\"]"));
}
