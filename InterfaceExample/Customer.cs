using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  Country { get; set; }
        public string LastName { get  ; set ; }
    }
}
