using System;
using System.Collections.Generic;
using EmployeeDataAnalyzerApp.Model;
using System.IO;

namespace EmployeeDataAnalyzerApp.Model
{
    public class EmployeeFileReader
    {
        public void ReadFromFile(EmployeeManager employeeManager,string fileName)
        {
            string[] fileRows = File.ReadAllLines(fileName);
            foreach(var row in fileRows)
            {
                string[] data = row.Split(',');
                employeeManager.AddEmployee(new Employee(Convert.ToInt32(data[0]),data[1],data[2],
                                            Convert.ToInt32(CheckIfLineNull(data[3])),data[4],Convert.ToDouble(data[5]),
                                            CheckIfLineNull(data[6]),Convert.ToInt32(data[7])));
            }
        }
        public double CheckIfLineNull(string obj) 
        {
            if (obj == "NULL") return 0;
            return Convert.ToDouble(obj);
        }
    }
}
