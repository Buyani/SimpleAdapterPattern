using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterSample
{
    public class EmployeeAdapter : HRSystem, ITarget
    {
        public  List<string> GetEmployeeList()
        {
            List<string> employeeList = new List<string>();
            string[][] employees = GetEmployees();

            foreach (var employee in employees)
            {
                employeeList.Add(employee[0]);
                employeeList.Add(",");
                employeeList.Add(employee[1]);
                employeeList.Add(",");
                employeeList.Add(employee[2]);
                employeeList.Add("\n");

            }

            return employeeList;
        }
    }
}
