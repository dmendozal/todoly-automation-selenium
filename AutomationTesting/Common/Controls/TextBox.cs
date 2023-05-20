using OpenQA.Selenium;

namespace AutomationTesting.Common.Controls;

public class TextBox : BaseControl
{
    public TextBox(By locator) : base(locator) { }

    public void SetText(string value)
    {
        FindControl();
        _control.Clear();
        _control.SendKeys(value);
    }
}
