using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAnalyzerApp.Model
{
    public interface ILoadData
    {
        void ReadData(EmployeeManager employee);
    }
}
