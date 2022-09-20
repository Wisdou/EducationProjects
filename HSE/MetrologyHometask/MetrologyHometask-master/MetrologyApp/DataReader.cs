using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace MetrologyHometask
{
    /// <summary>
    /// DataReader class
    /// </summary>
    public static class DataReader
    {
        ///<summary>Get needed data from text file.</summary>
        /// <param name="path">Path to file with data.</param>
        /// <param name="splitter">Symbol that should be used as splitter of data.</param>
        /// <param name="encoding">Chosen encoding.</param>
        /// <returns>An IEnumerable of type System.Double containing data from file.</returns>
        public static IEnumerable<double> ReadTXTFile(string path, char splitter = ' ', Encoding encoding = null)
        {
            if (splitter == '.' || splitter == ',')
            {
                throw new ArgumentException("Split value must not equal to '.' or ','.");
            }
            encoding ??= Encoding.UTF8;
            string informationFromFile = File.ReadAllText(path);
            IEnumerable<string> parsedDoubles = informationFromFile.Split(splitter).
                                                Select(x => x.Replace(",", ".").Trim()).
                                                Where(x => Regex.IsMatch(x, @"^-?\d+(?:\.?\d+)?\Z"));
            return parsedDoubles.Select(x => Double.Parse(x.Trim(), System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
