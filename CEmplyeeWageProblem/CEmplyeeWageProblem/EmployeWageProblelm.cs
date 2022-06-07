using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEmplyeeWageProblem
{
    internal class EmployeWageProblelm
    {
        int IS_EmpPresent = 1;
        int Wage_Per_Hour = 20;
        int FullDay_Hour = 8;
        int DailyWage = 0;
        public void DailyEmpWg()
        {
            Random ChechEmp = new Random();
            int value = ChechEmp.Next(0, 2);
            if (value == IS_EmpPresent)
            {
                DailyWage = FullDay_Hour * Wage_Per_Hour;

                Console.WriteLine("Employee Present" + DailyWage);

            }
            else
            {
                Console.WriteLine("Employee Absent");

            }

        }
    }
}
