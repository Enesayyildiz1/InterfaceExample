using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class PersonManager
    {
        
        public void Add(IPerson   person  )
        {
            Console.WriteLine(person  . FirstName);
            
        }
    }
}
