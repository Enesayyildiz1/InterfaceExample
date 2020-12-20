using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Delete();
        void Update();
    }
    class SqlDatabase : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added.");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated.");
        }
    }
    class OracleDatabase : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added.");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated.");
        }
    }
    class CustomerManager
    {
        public void Do(ICustomerDal customerDal )
        {
            customerDal.Add();
            customerDal.Delete();
            customerDal.Update();
        }
    }
}
