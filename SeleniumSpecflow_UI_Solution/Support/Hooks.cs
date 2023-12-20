[Binding]
public class Hooks
{
    [BeforeScenario]
    public static void BeforeScenario()
    {
        //Inicializo el ambiente y el driver de la app
        EnviromentManager.InitializeEnviroment();
        WebDriver.InitializeWebDriver();
    }

    //Este binding permite realizar actividades posteriores a cada escenario
    [AfterScenario]
    public static void AfterScenario()
    {
        if (WebDriver.webDriver != null)
        {
            WebDriver.webDriver.Quit();
        }
    }
}