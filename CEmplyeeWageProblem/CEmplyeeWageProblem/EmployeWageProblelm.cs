using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEmplyeeWageProblem
{
    internal class EmployeWageProblelm
    {
        public const float EmpWagesPerHour = 20;
        public const int FullTime_WorkingHrs_PerDay = 8;
        public const int PartTime_WorkingHrs_PerDay = 4;
        public const int MAX_WORKING_HRS = 100;
        public const int MAX_WORKING_DAYS = 20;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 0;
        public float TotalWage = 0;
        float EmpDailyWage = 0;


        //c# object-oriented class -object
        //checking functionality write a metod
        public int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }

        public void CalculateEmpWage()

        {
            int DayNumber = 1;
            int EmpWorkingHrs = 0;
            int TotalWorkingHrs = 0;

            //Random EmpCheck = new Random();//Random=class EmpCheck=object
            //int Value = EmpCheck.Next(0, 3); //next=method .next it is a method  returns a non-negative integer

            //for (int daymunber = 1; daymunber)
            while (DayNumber <= MAX_WORKING_DAYS && TotalWorkingHrs <= MAX_WORKING_HRS)
            {
                switch (IsEmployeePresent())

                {
                    case IS_ABSENT:
                        EmpWorkingHrs = 0;
                        break;

                    case IS_PART_TIME:
                        EmpWorkingHrs = PartTime_WorkingHrs_PerDay;
                        break;
                    case IS_FULL_TIME:
                        EmpWorkingHrs = FullTime_WorkingHrs_PerDay;
                        break;
                }
                EmpDailyWage = EmpWorkingHrs * EmpWagesPerHour;
                TotalWage += EmpDailyWage;

                DayNumber++;
                TotalWorkingHrs += EmpWorkingHrs;
            }
            Console.WriteLine("Total working days :" + (DayNumber) + "\nTotal working hours:" + TotalWorkingHrs + "");

        }
    }
}
