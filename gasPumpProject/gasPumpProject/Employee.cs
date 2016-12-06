﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//employee entity class, assigns each employee a unique employee ID upon creation

namespace gasPumpProject
{
    class Employee
    {
        //keeps track of total employees created
        private static int employees = 0;

        //employee ID backing value for custom getter/setter
        private int EmployeeID;
        public int employeeID 
        {   get { return EmployeeID; }
            set
            {
                EmployeeID = value;
                if(EmployeeID >= employees)
                    employees = EmployeeID;
                employees++;
            }
        }

        //increment number of employees and assign the new employee thier ID
        public Employee(int ID)
        {
            this.employeeID = ID;
        }

    }
}