using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWork[] work = new IWork[] { new manager(), new robot(), new worker() };
            foreach (var worker in work)
            {
                worker.work();
            }

            Console.WriteLine("---------------------------------------------------");

            IEat[] eat = new IEat[] { new manager(), new worker() };
            foreach (var worker in eat)
            {
                worker.eat();
            }

            Console.WriteLine("---------------------------------------------------");

            IgetSalary[] salary = new IgetSalary[] { new worker(), new manager() };
            foreach (var worker in salary)
            {
                worker.getSalary();
            }

            Console.ReadLine();
        }
    }
}
