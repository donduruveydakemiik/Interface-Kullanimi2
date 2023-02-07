using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces
{
    internal interface IWork
    {
        void work();        
    }

    internal interface IEat
    {
        void eat();
    }

    internal interface IgetSalary

    {
        void getSalary();
    }

    class robot : IWork
    {
        public void work()
        {
            Console.WriteLine("Robot çalıştı.");
        }
    }

    class manager : IWork, IEat, IgetSalary

    {
        public void eat()
        {
            Console.WriteLine("Yönetici yemek yedi");
            
        }

        public void getSalary()
        {

            Console.WriteLine("Yönetici maaş aldı.");
        }

        public void work()
        {
            Console.WriteLine("Yönetici çalıştı.");
        }
    }

    class worker : IWork, IEat, IgetSalary

    {
        public void eat()
        {
            Console.WriteLine("Çalışan yemek yedi");
        }

        public void getSalary()
        {
            Console.WriteLine("Çalışan maaş aldı.");
        }
            public void work()
        {
            Console.WriteLine("Çalışan çalıştı.");
        }
    }
}
