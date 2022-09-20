using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetrologyHometask
{
    public class CombinatoricalCriteria: ICriteria
    {
        private static readonly (int, int)[][] table = new (int, int)[][]
        {
            new (int,int)[]{(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0)},
            new (int,int)[]{(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0)},
            new (int,int)[]{(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0)},
            new (int,int)[]{(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0)},
            new (int,int)[]{(0,0),(0,0),(0,0),(0,0),(2,8),(2,8),(3,9),(3,9),(3,10),(3,10),(3,10),(3,10),(4,10)},
            new (int,int)[]{(0,0),(0,0),(0,0),(0,0),(2,8),(2,8),(3,9),(3,9),(3,10),(3,10),(3,10),(3,10),(4,10)},
            new (int,int)[]{(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(3,11),(3,11),(4,12),(4,12),(5,12),(5,12),(5,13)},
            new (int,int)[]{(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(3,11),(3,11),(4,12),(4,12),(5,12),(5,12),(5,13)},
            new (int,int)[]{(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(5,13),(5,13),(6,14),(6,14),(6,15)},
            new (int,int)[]{(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(5,13),(5,13),(6,14),(6,14),(6,15)},
            new (int,int)[]{(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(6,16),(6,16),(7,17)},
            new (int,int)[]{(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(6,16),(6,16),(7,17)},
            new (int,int)[]{(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(0,0),(8,18)}
        };
        public string CheckCriteria(IEnumerable<double> data)
        {
            if (data.Count() == 0)
            {
                throw new ArgumentException("Data can not been empty.");
            }
            double average = Analyser.Mean(data);
            int A = data.Count(x => x >= average);
            int B = data.Count(x => x < average);
            bool[] array = data.Select(x => x >= average).ToArray();
            int count = 1;
            for (int i = 1; i < data.Count(); i++)
            {
                if (array[i] != array[i - 1])
                {
                    count++;
                }
            }
            if (A > 12 || B > 12)
            {
                throw new ArgumentException("Wrong input!");
            }
            else
            {
                bool checker = CombinatoricalCriteria.table[Math.Min(A, B)][Math.Max(A, B)].Item1 <= count && 
                               CombinatoricalCriteria.table[Math.Min(A, B)][Math.Max(A, B)].Item2 >= count;
                return $"Число элементов, которые больше среднего: {A}.\n" +
                       $"Число элементов, которые меньше среднего: {B}.\n" +
                       $"Число серий: {count}.\n" +
                       $"Удовлетворяет комбинаторному критерию: {(checker ? "Да" : "Нет")}\n" +
                       $"Систематическая погрешность {(checker ? "отсутствует" : "присутствует")}";
            }
        }
    }
}
