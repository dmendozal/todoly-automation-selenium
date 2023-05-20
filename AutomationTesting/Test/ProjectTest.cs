using AutomationTesting.Common.Pages;
using AutomationTesting.Common.Session;

namespace AutomationTesting.Test;

[TestClass]
public class ProjectTest : TestBase
{
    private readonly MainPage _mainPage = new();
    private readonly LoginSection _loginSection = new();
    private readonly LeftSide _leftSide = new();


    [TestMethod]
    public void VerifyCRUDProject()
    {
        _mainPage.loginButton.Click();
        _loginSection.Login("bootcamp2@mojix.com", "12345");

        _leftSide.AddNewProjectBtn.Click();
        _leftSide.ProjectNameTxtBox.SetText("Mojix909090");
        _leftSide.AddBtn.Click();

        // add verificacion
        Assert.IsTrue(_leftSide.ProjectNameIsDisplayed("Mojix909090"), "ERROR!The project was not created");

        _leftSide.ClickProjectName("Mojix909090");
        _leftSide.SubMenuIcon.Click();
        _leftSide.EditBtn.Click();
        _leftSide.EditProjectNameBtn.SetText("MojixUpdateddddd");
        _leftSide.SaveBtn.Click();

        // add verificacion
        Assert.IsTrue(_leftSide.ProjectNameIsDisplayed("MojixUpdateddddd"), "ERROR!The project was not updated");

        _leftSide.ClickProjectName("MojixUpdateddddd");
        _leftSide.SubMenuIcon.Click();
        _leftSide.DeleteBtn.Click();

        Thread.Sleep(1000);
        SingletonSession.Instance().GetBrowser().SwitchTo().Alert().Accept();
        Thread.Sleep(1000);
        // add verificacion
        Assert.IsFalse(_leftSide.ProjectNameIsDisplayed("MojixUpdateddddd"), "ERROR!The project was not deleted");
    }
}
