using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MetrologyHometask
{
    public class AbbeCriteria : ICriteria
    {
        private static readonly double[] criticalQ_NinetyFive = new double[]
        {
            0,
            0,
            0,
            0,
            0.390,
            0.410,
            0.445,
            0.468,
            0.491,
            0.512,
            0.531,
            0.548,
            0.564,
            0.578,
            0.591,
            0.603,
            0.614,
            0.624,
            0.633,
            0.642,
            0.650
        };

        private static readonly double[] criticalQ_NinetyNine = new double[]
        {
            0,
            0,
            0,
            0,
            0.313,
            0.269,
            0.281,
            0.307,
            0.331,
            0.354,
            0.376,
            0.396,
            0.414,
            0.431,
            0.447,
            0.461,
            0.474,
            0.487,
            0.499,
            0.510,
            0.520
        };

        public string CheckCriteria(IEnumerable<double> data)
        {
            if (data.Count() < 4)
            {
                throw new ArgumentException("Data must contains more than three elements");
            }
            double[] arr = data.ToArray();
            double unbiasedVar = Analyser.UnbiasedVariance(data);
            double qx = Enumerable.Range(1, arr.Length - 1).Sum(i => (arr[i] - arr[i - 1]) * (arr[i] - arr[i - 1])) / (2 * (arr.Length - 1));
            double A = qx / unbiasedVar;
            double criticalQ95 = (criticalQ_NinetyFive.Length <= arr.Length) ? -2.0 : criticalQ_NinetyFive[arr.Length];
            bool checker95 = A < criticalQ95;
            double criticalQ99 = (criticalQ_NinetyNine.Length <= arr.Length) ? -2.0 : criticalQ_NinetyNine[arr.Length];
            bool checker99 = A < criticalQ99;
            string check95 = (criticalQ95 <= -1.0) ? $"Для проверки критерия Аббе при доверительной вероятности 0.95 число измерений должно быть меньше {criticalQ_NinetyFive.Length}.\n" :
                                                     $"Критическое значение для числа элементов {arr.Length} и доверительной вероятности 0.95: {criticalQ95}.\n" +
                                                     $"Есть систематическая ошибка по критерию Аббе при уровне значимости 0.95: {(checker95 ? "Да" : "Нет")}\n";
            string check99 = (criticalQ99 <= -1.0) ? $"Для проверки критерия Аббе при доверительной вероятности 0.99 число измерений должно быть меньше {criticalQ_NinetyNine.Length}.\n" :
                                                     $"Критическое значение для числа элементов {arr.Length} и доверительной вероятности 0.99: {criticalQ99}.\n" +
                                                     $"Есть систематическая ошибка по критерию Аббе при уровне значимости 0.99: {(checker99 ? "Да" : "Нет")}\n";
            return $"Критерий Аббе: \n" +
                   $"Выборочная дисперсия {unbiasedVar}.\n" +
                   $"Сумма квадратов последовательных разностей: {qx}.\n" +
                   $"Критерий Аббе: {A}.\n" +
                   check95 + check99;
        }
    }
}