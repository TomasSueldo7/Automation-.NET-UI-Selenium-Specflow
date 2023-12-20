using NUnit.Framework;

[Binding]
public class LogInStepDefinitions
{
    private LoginPage loginPage;
    private HomePage homePage;
    private Consumer consumer;

    public LogInStepDefinitions()
    {
        loginPage = new LoginPage(WebDriver.webDriver);
        consumer = new Consumer(EnviromentManager.user, EnviromentManager.psw);
    }

    [Given(@"the user is in the website")]
    public void GivenTheUserIsInTheWebsite()
    {
        Assert.IsNotNull(WebDriver.webDriver);
    }

    [When(@"the user logs in with email & password")]
    public async Task WhenTheUserLogsInWithEmailPassword()
    {
        this.homePage = loginPage.Login(consumer.Username, consumer.Password);
    }

    [When(@"the user logs in with email (.*) & password (.*)")]
    public void WhenTheUserLogsInWithEmailPassword(string user, string psw)
    {
        loginPage.LoginError(user, psw);
    }

    [Then(@"the system shows the home page")]
    public void ThenTheSystemShowsTheHomePage()
    {
        Assert.IsNotNull(this.homePage);
    }


    [Then(@"the system shows a login error message")]
    public void ThenTheSystemShowsALoginErrorMessage()
    {
        loginPage.ValidateError();
        Assert.IsNotNull(loginPage.NotificationError);
    }

    [When(@"the user logs out")]
    public void WhenTheUserLogsOut()
    {
        this.loginPage = homePage.LogOut();
        
    }

    //Verifica que efectivamente se haya cerrado la sesión
    [Then(@"the system shows the log in page")]
    public void ThenTheSystemShowsTheLogInPage()
    {
        Assert.IsNotNull(this.loginPage);
        Assert.IsNotNull(this.loginPage.UsernameField);
        Assert.IsNotNull(this.loginPage.PasswordField);
        Assert.IsNotNull(this.loginPage.LoginButton);
    }
}
