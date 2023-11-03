using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDB.Model
{
    public class AddressBooks
    {
         public int Id { get; set; }
         public string Name { get; set; }
         public string LastName { get; set; }
         public string FullName { get; set; }
         public string TypeUser { get; set; }
         public string Address { get; set; }
    }
}
