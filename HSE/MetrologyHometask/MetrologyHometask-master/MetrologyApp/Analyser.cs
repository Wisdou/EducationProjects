using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetrologyHometask
{
    /// <summary>
    /// Analyser class. Contains methods for finding statistical parameters.
    /// </summary>
    public static class Analyser
    {
        /// <summary>
        /// Get mean of input data
        /// </summary>
        /// <param name="data">Data</param>
        /// <returns></returns>
        public static double Mean(IEnumerable<double> data)
        {
            return data.Average();
        }

        /// <summary>
        /// Get variance of input data
        /// </summary>
        /// <param name="data">Data</param>
        /// <returns></returns>
        public static double Variance(IEnumerable<double> data)
        {
            double mean = Analyser.Mean(data);
            return data.Select(x => (x - mean) * (x - mean)).Average();
        }

        /// <summary>
        /// Get unbiased variance of input data
        /// </summary>
        /// <param name="data">Data</param>
        /// <returns></returns>
        public static double UnbiasedVariance(IEnumerable<double> data)
        {
            double mean = Analyser.Mean(data);
            return data.Select(x => (x - mean) * (x - mean)).Sum() / (data.Count() - 1);
        }

        /// <summary>
        ///  Get mean square deviation of input data
        /// </summary>
        /// <param name="data">Data</param>
        /// <returns></returns>
        public static double MeanSquareDeviation(IEnumerable<double> data)
        {
            return Math.Sqrt(Variance(data));
        }

        /// <summary>
        /// Get median of input data
        /// </summary>
        /// <param name="data">Data</param>
        /// <returns></returns>
        public static double Median(IEnumerable<double> data)
        {
            if (data.Count() == 0)
            {
                return 0.0;
            }
            double[] ordereddata = data.OrderBy(x => x).ToArray();
            return (ordereddata.Length % 2 == 0) ? (ordereddata[ordereddata.Length / 2] + ordereddata[ordereddata.Length / 2 - 1]) / 2 : ordereddata[ordereddata.Length / 2];
        }

        /// <summary>
        /// Get range of input data
        /// </summary>
        /// <param name="data">Data</param>
        /// <returns></returns>
        public static double Range(IEnumerable<double> data)
        {
            if (data.Count() == 0)
            {
                return 0.0;
            }
            return data.Max() - data.Min();
        }

        /// <summary>
        /// Get report, that contains statistical parameters of the input
        /// </summary>
        /// <param name="data">Data</param>
        /// <returns></returns>
        public static string GetReport(IEnumerable<double> data)
        {
            if (data.Count() == 0)
            {
                throw new ArgumentException("Data must contain at least one element.");
            }
            double mean = Analyser.Mean(data);
            double variation = Analyser.Variance(data);
            double unbiasedVariation = Analyser.UnbiasedVariance(data);
            double meanSqDev = Analyser.MeanSquareDeviation(data);
            double median = Analyser.Median(data);
            double range = Analyser.Range(data);
            return $"Среднее значение: {mean}.\n" +
                   $"Дисперсия: {variation}.\n" +
                   $"Несмещенная дисперсия: {unbiasedVariation}.\n" +
                   $"Среднее квадратическое отклонение: {meanSqDev}.\n" +
                   $"Медиана: {median}.\n" +
                   $"Размах: {range}.";
        }
    }
}