using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
            string[] result = new string[l];
            for (int i = 0; i < l; i++)
            {
                string r = Console.ReadLine();
                if (r.Length > 10)
                {
                    result[i] = r[0] + (r.Length - 2).ToString() + r[r.Length - 1];
                }
                else
                {
                    result[i] = r;
                }
            }
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
