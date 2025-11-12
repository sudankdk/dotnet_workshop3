namespace task1;

class Program
{
    static void Main(string[] args)
    {
        Operators operators = new Operators();
        int ans = operators.Add(2, 3);
        int subs = operators.Subtract(5, 2);
        int product =operators.Multiply(5, 2);
       var  ( val , msg)=operators.Divide(5, 0);
        var oddEven = operators.OddEvenFinder(14);
        Console.WriteLine(oddEven);
        Console.WriteLine(ans);
        Console.WriteLine(product);
        Console.WriteLine($"{msg}: {val}");
        Console.WriteLine(subs);
        Console.WriteLine(ans);
    }
}
