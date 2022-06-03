using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_03._06._2022
{
    class Employee
    {
        protected string _name;
        protected string _surname;
        protected int _salary;

        public string Name
        {
            get {
                return _name;
            }
            set
            {
                int count = 0;
                for(int i = 0; i < value.Length; i++)
                {
                    if (Char.IsUpper(value[]) && Char.IsUpper(value[i]))
                    {
                        count++;
                    }

                    if (count == value.Length)
                    {
                        _name = value;
                    }

                    
                }
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                int count = 0;
                for(int i = 0; i < value.Length; i++)
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        _surname = value;
                    }
                }
            }
        }
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if(Salary > 250)
                {
                    _salary = Salary;
                }
            }
        }
    }
}
