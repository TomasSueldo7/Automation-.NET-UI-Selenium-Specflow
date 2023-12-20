public class Consumer
{
    public string Username { get; set; }
    public string Password { get; set; }

    public Consumer(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public Consumer() { }
}