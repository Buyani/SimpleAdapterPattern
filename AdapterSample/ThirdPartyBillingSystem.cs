using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace AdapterSample
{
    public class ThirdPartyBillingSystem
    {
        private ITarget employeeSource;
        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }
        public void ShowEmployeeList()
        {
            List<string> employee = employeeSource.GetEmployeeList();
            //To DO: Implement you business logic

            Console.WriteLine("######### Employee List ##########");
            foreach (var item in employee)
            {
                Console.Write(item);
            }
        }
    }
}

