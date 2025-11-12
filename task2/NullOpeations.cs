namespace task2;

public class NullOpeations
{
    public  void PerformNullCheck()
    {
       string username = null;
       string messgae= (username == null )? "username is not available " : username;
       Console.WriteLine(username);
        Console.WriteLine(  username ?? "Guest");
        username ??= "User";
        Console.WriteLine("Updated username: " + username);
    }
}