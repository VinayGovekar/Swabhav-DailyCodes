using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyEmployeeDataAnalyzerApp.Model.Loader
{
    public class CheckRedundantEmployee
    {
        public bool CheckIfEmployeeAlreadyPresent(Employee employee, List<Employee> data)
        {
            if (data.Contains(employee)) return true;
            return false;
        }
        public double CheckIfLineNull(string obj)
        {
            if (obj == "NULL") return 0;
            return Convert.ToDouble(obj);
        }
    }
}
