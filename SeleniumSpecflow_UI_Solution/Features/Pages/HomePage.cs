
using OpenQA.Selenium;

public class HomePage
{
    private IWebDriver driver;
    public IWebElement Title;
    public IWebElement LogOutBtn;

    public HomePage(IWebDriver driver)
    {
        this.driver = driver;
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

        Title = driver.FindElement(By.CssSelector("div h1"));
        LogOutBtn = driver.FindElement(By.LinkText("Log out"));
    }

    public LoginPage LogOut()
    {
        LogOutBtn.Click();

        LoginPage logInPage = new LoginPage(this.driver);
        return logInPage;
    }

}
