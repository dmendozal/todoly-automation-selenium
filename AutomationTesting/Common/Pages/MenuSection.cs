using AutomationTesting.Common.Controls;
using OpenQA.Selenium;

namespace AutomationTesting.Common.Pages;

internal class MenuSection
{
    public Button logoutButton = new(By.Id("ctl00_HeaderTopControl1_LinkButtonLogout"));
}
