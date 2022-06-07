using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEmplyeeWageProblem
{
    internal class EmployeWageProblelm
    {
        public int Is_EmpPresent = 1;

        public void CheckEmpPresentAbsent()
        {
            Random ChechEmp = new Random();
            int value = ChechEmp.Next(0, 2);
            if (value == Is_EmpPresent)
            {
                Console.WriteLine("Employee Present");

            }
            else
            {
                Console.WriteLine("Employee Absent");

            }

        }
    }
}
