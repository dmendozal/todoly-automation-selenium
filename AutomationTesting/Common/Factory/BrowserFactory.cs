namespace AutomationTesting.Common.Factory;

public class BrowserFactory
{
    public static IBrowser Make(string browserType)
    {
        return browserType switch
        {
            "chrome" => new ChromeBrowser(),
            _ => throw new NotImplementedException()
        };
    }
}
