using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            Demo();
            Console.WriteLine("----------------------");
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlDatabase() ,
                new OracleDatabase()
            };
            foreach (var database in customerDals)
            {
                database.Add();
                database.Delete();
                database.Update();
            }

            Console.ReadKey();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Do (new SqlDatabase());
            customerManager.Do (new OracleDatabase());
           
           
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();

            manager.Add(new Student
            {
                FirstName = "Enes"
            });
            manager.Add(new Customer
            {
                FirstName = "Emre"
            });
            manager.Add(new Employee
            {
                FirstName = "Mahmut"
            });
        }
    }
}
