using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_03._06._2022
{
    class Department:Employee
    {
        public string Name;
        public int Employee;
        public int EmployeeLimit;
        public int SalaryLimit = 120;
        private Employee[] _employees = new Employee[0];

        public Department(int employeeLimit)
        {
            EmployeeLimit = employeeLimit;

        }

        public Employee[] Employees
        {
            get => _employees;
        }

        public void AddEmloyee(Employee employee)
        {   
            if (_employees.Length < EmployeeLimit) 
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = employee;
                    
            }
        }
            
            
            
    }
}
