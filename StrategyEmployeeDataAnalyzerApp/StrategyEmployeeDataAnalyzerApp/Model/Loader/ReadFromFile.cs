using System;
using System.Collections.Generic;
using System.IO;

namespace StrategyEmployeeDataAnalyzerApp.Model.Loader
{
    public class ReadFromFile : ILoadData
    {  
        public List<Employee> LoadData()
        {
            List<Employee> employeeData = new List<Employee>();
            string dataString = Directory.GetCurrentDirectory() + "/employeeData.txt";
            string[] fileRows = File.ReadAllLines(dataString);
            var checker = new CheckRedundantEmployee();
            foreach (var row in fileRows)
            {
                string[] data = row.Split(',');
                Employee newEmployee = new Employee(Convert.ToInt32(data[0]), data[1], data[2],
                                            Convert.ToInt32(checker.CheckIfLineNull(data[3])), data[4], Convert.ToDouble(data[5]),
                                            checker.CheckIfLineNull(data[6]), Convert.ToInt32(data[7]));
                if (!checker.CheckIfEmployeeAlreadyPresent(newEmployee,employeeData)) employeeData.Add(newEmployee);
            }
            return employeeData;
        }
        
    }
}
