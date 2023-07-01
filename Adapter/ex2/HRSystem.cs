using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.ex2
{

    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    public class HRSystem
    {
        public string[][] GetEmployees()
        {
            string[][] employees = new string[4][];

            employees[0] = new [] { "100", "Deepak", "Team Leader" };
            employees[1] = new [] { "101", "Rohit", "Developer" };
            employees[2] = new [] { "102", "Gautam", "Developer" };
            employees[3] = new [] { "103", "Dev", "Tester" };

            return employees;
        }
    }

}
