﻿using System;
namespace EmployeeWageComputation
{
    public class Attendance
    {
        const int IS_PRESENT = 1;
        public void attendance()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}