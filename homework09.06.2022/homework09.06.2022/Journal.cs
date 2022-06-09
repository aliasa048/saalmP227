using System;
using System.Collections.Generic;
using System.Text;

namespace homework09._06._2022
{
    class Journal:Product
    {
        public string  Company;

        public override void GetInfo()
        {
            Console.WriteLine($"name: {Name} company: {Company}");
        }
    }
}
