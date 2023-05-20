using AutomationTesting.Common.Pages;

namespace AutomationTesting.Test;


[TestClass]
public class LoginTest : TestBase
{
    readonly MainPage mainPage = new();
    readonly LoginSection loginSection = new();
    readonly MenuSection menuSection = new();



    [TestMethod]
    public void VerifyTheLoginIsSuccessfuly()
    {
        mainPage.loginButton.Click();
        loginSection.EmailTxtBox.SetText("bootcamp2@mojix.com");
        loginSection.PasswordTxtBox.SetText("12345");
        loginSection.LoginBtn.Click();

        Assert.IsTrue(menuSection.logoutButton.IsControlDisplayed(),
            "ERROR !! the login was not successfully, review credentials please");
    }
}
