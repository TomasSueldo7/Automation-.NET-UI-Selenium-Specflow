using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public static class WebDriver
{
    public static IWebDriver webDriver;
    public static void InitializeWebDriver()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--start-maximized");
        options.AddExcludedArgument("disable-popup-blocking");

        string url = EnviromentManager.website;
        Uri uri = new Uri(url);

        webDriver = new ChromeDriver(options);
        webDriver.Navigate().GoToUrl(uri);
    }
}