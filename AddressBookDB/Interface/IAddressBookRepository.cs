using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDB.Interface
{
    public interface IAddressBookRepository : IDisposable
    {
        IQueryable<AddressBook> GetAddressBooks();
        bool IsAddressBookExist(string Name, string LastName);
        bool AddAddressBook(string Name, string LastName, string Address, string userType);
    }
}
