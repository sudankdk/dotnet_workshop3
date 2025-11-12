namespace task1;

public class Operators
{
    public  int Add(int x, int y)
    {
        return x + y;
    }

    public  int Subtract(int x, int y)
    {
        return x - y;
    }

    public  int Multiply(int x, int y)
    {
        return x * y;
    }

    public  (float,string) Divide(int x, int y)
    {
        try
        {
            float result =(float) x / y;
            return (result,"success");
        }catch (Exception e)
        {
            Console.WriteLine(e);
            return (0,$"Error {e.Message}");
        }
    }

    public  string OddEvenFinder(int x)
    {
        return x%2==0 ?  $"even number {x} " : $"odd number {x}";
    }
}