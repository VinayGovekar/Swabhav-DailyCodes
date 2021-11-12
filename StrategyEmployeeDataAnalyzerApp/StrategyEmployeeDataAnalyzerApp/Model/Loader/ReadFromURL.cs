using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace StrategyEmployeeDataAnalyzerApp.Model.Loader
{
    public class ReadFromURL:ILoadData
    {
        
    public List<Employee> LoadData()
        {
            string url = "https://swabhav-tech.firebaseapp.com/emp.txt";
            List<Employee> _employeeData = new List<Employee>();
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseText = reader.ReadToEnd();
            StringReader stringReader = new StringReader(responseText);
            bool condition = true;
            List<string> fileRows = new List<string>();
            while (condition)
            {
                string data = stringReader.ReadLine();
                if (data != null) fileRows.Add(data);
                else condition = false;

            }
            var checker = new CheckRedundantEmployee();
            foreach (var row in fileRows)
            {
                string[] data = row.Split(',');
                Employee newEmployee = new Employee(Convert.ToInt32(data[0]), data[1], data[2],
                                            Convert.ToInt32(checker.CheckIfLineNull(data[3])), data[4], Convert.ToDouble(data[5]),
                                            checker.CheckIfLineNull(data[6]), Convert.ToInt32(data[7]));
                if (!checker.CheckIfEmployeeAlreadyPresent(newEmployee, _employeeData)) _employeeData.Add(newEmployee);
            }
            return _employeeData;
        }
    }
}
