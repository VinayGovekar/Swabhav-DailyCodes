using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyEmployeeDataAnalyzerApp.Model
{
    public interface ILoadData
    {
        List<Employee> LoadData();
    }
}
