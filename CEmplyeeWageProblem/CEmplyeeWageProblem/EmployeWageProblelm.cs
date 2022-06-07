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
    int PartTimeDay_Hour = 4;
    int DailyWage = 0;
    int Full_Time = 1;
    public void DailyEmpWgPartTime()
    {
        Random ChechEmp = new Random();
        int value = ChechEmp.Next(0, 2);
        if (value == IS_EmpPresent)
        {
            Random TimeChech = new Random();
            int DayCheck = TimeChech.Next(0, 2);
            if (DayCheck == Full_Time)
            {

                DailyWage = FullDay_Hour * Wage_Per_Hour;

                Console.WriteLine("Employee Present" + DailyWage);
            }
            else
            {
                DailyWage = PartTimeDay_Hour * Wage_Per_Hour;

                Console.WriteLine("Employee Present for partTime" + DailyWage);
            }






        }
        else
        {
            Console.WriteLine("Employee Absent");

        }

    }
}
}
