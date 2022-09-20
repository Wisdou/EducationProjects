using System;
using System.Collections.Generic;
using System.Text;

namespace MetrologyHometask
{
    public interface ICriteria
    {
        public string CheckCriteria(IEnumerable<double> data);
    }
}
