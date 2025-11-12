using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = 5;
            for (int i = 0; i <= input; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------------------------------------------------");

            var num = 20;
            while (num > 1)
            {
                Console.WriteLine(num);

                if (num == 15)
                {
                    break;
                }

                num--; // decrement before continue check

                if (num % 4 == 0)
                {
                    continue;
                }
            }

            int[] nums = { 1, 2, 4, 5, 6, 7 };
            var add = 0;
            foreach (var n in nums)
            {
                add += n;
            }

            Console.WriteLine(add);
        }
    }
}