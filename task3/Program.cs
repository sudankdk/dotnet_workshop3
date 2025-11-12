namespace task3;

class Program
{
    static void Main(string[] args)
    {
        int age = 21;
        if (age < 13)
        {
            Console.WriteLine("child");
        }else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("teenager");
        }
        else
        {
            Console.WriteLine("Adult");
        }
    }
}