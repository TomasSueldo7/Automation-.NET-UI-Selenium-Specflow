using NUnit.Framework;

public static class EnviromentManager
{
    public static string? website;
    public static string? user;
    public static string? psw;

    public static void InitializeEnviroment()
    {
        website = TestContext.Parameters["WebSite"];
        user = TestContext.Parameters["Username"];
        psw = TestContext.Parameters["Password"];
    }
}