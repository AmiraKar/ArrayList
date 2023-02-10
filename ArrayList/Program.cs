using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public class Person
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Numbers = new List<int>();
            Random r = new Random();
            for (int x = 0; x < 10; x++)
            {
                int num = r.Next(0, 100);
                Numbers.Add(num);
            }
            foreach (var number in Numbers)
            { Console.Write(number + ""); }
            Console.WriteLine("...................");
            Console.WriteLine("Average of random numbers is:{0}", Numbers.Average());
            Numbers.Insert(10, 0);
            var index = Numbers.IndexOf(0);
            Console.WriteLine("index of position 0 is : {0}", index);
            Console.ReadLine();
        }
    }
}
