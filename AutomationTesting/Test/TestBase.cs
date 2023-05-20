using AutomationTesting.Common.Session;

namespace AutomationTesting.Test;

[TestClass]
public class TestBase
{
    [TestInitialize]
    public void OpenBrowser()
    {
        SingletonSession.Instance().GetBrowser().Navigate().GoToUrl("http://todo.ly");
    }

    [TestCleanup]
    public void CloseBrowser()
    {
        SingletonSession.Instance().CloseBrowser();
    }
}
