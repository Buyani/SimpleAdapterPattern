﻿using System;

namespace AdapterSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new EmployeeAdapter();
            var client = new ThirdPartyBillingSystem(target);
            client.ShowEmployeeList();

            Console.ReadKey();


        }
    }
}
