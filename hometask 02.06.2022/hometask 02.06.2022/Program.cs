using System;

namespace hometask_02._06._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();

            user1.SetPassword("Salam345");

            Console.WriteLine(user1.GetPassword());
           
        }
    }
}
