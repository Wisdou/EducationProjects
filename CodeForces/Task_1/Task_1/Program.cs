using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = Convert.ToInt32(Console.ReadLine());
            if (w > 2 && w % 2 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
