using AutomationTesting.Common.Controls;
using OpenQA.Selenium;

namespace AutomationTesting.Common.Pages
{
    public class LeftSide
    {
        public Button AddNewProjectBtn = new(By.XPath("//td[text()='Add New Project']"));
        public TextBox ProjectNameTxtBox = new(By.Id("NewProjNameInput"));
        public Button AddBtn = new(By.Id("NewProjNameButton"));

        public Button SubMenuIcon = new(By.XPath("//div[contains(@style,'block')]/img"));
        public Button EditBtn = new(By.XPath("//ul[contains(@style,'block')]//a[text()='Edit']"));
        public TextBox EditProjectNameBtn = new(By.XPath("//td/div/input[@id='ItemEditTextbox']"));
        public Button SaveBtn = new(By.XPath("//td/div/img[@id='ItemEditSubmit']"));

        public Button DeleteBtn = new(By.Id("ProjShareMenuDel"));
        
        public bool ProjectNameIsDisplayed(string nameValue)
        {
            Label nameProject = new(By.XPath("(//ul[@id=\"mainProjectList\"]/li//td[text()='" + nameValue + "'])[last()]"));
            return nameProject.IsControlDisplayed();
        }

        public void ClickProjectName(string nameValue)
        {
            Label nameProject = new(By.XPath("(//ul[@id=\"mainProjectList\"]/li//td[text()='" + nameValue + "'])[last()]"));
            nameProject.Click();
        }
    }
}
