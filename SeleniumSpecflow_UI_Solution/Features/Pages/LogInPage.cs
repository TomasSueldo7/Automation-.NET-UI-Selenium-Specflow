using OpenQA.Selenium;

public class LoginPage
{
    private IWebDriver driver;
    public IWebElement UsernameField;
    public IWebElement PasswordField;
    public IWebElement LoginButton;
    public IWebElement? NotificationError;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        UsernameField = driver.FindElement(By.Id("username"));
        PasswordField = driver.FindElement(By.Id("password"));
        LoginButton = driver.FindElement(By.CssSelector(".btn"));
    }

    public HomePage Login(string username, string password)
    {
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

        UsernameField.Clear();
        PasswordField.Clear();
        UsernameField.SendKeys(username);
        PasswordField.SendKeys(password);
        LoginButton.Click();

        HomePage homePage = new HomePage(driver);
        return homePage;
    }
    
    public void LoginError(string username, string password)
    {
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

        UsernameField.Clear();
        PasswordField.Clear();
        UsernameField.SendKeys(username);
        PasswordField.SendKeys(password);
        LoginButton.Click();
    }

    public void ValidateError()
    {
        NotificationError = driver.FindElement(By.Id("error"));
    }

}
