using AutomationTesting.Common.Controls;
using OpenQA.Selenium;

namespace AutomationTesting.Common.Pages;

public class LoginSection
{
    public TextBox EmailTxtBox = new(By.Id("ctl00_MainContent_LoginControl1_TextBoxEmail"));
    public TextBox PasswordTxtBox = new(By.Id("ctl00_MainContent_LoginControl1_TextBoxPassword"));
    public Button LoginBtn = new(By.Id("ctl00_MainContent_LoginControl1_ButtonLogin"));

    public void Login(string user, string pwd)
    {
        EmailTxtBox.SetText(user);
        PasswordTxtBox.SetText(pwd);
        LoginBtn.Click();
    }
}
