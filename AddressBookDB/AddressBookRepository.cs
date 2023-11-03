using AddressBookDB.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDB
{
    public class AddressBookRepository : IAddressBookRepository
    {
        AddressBookContext _Ctx;
        public AddressBookRepository(AddressBookContext Context)
        {
            _Ctx = Context;
            _Ctx.Context.Configuration.LazyLoadingEnabled = false;
            _Ctx.Context.Configuration.ProxyCreationEnabled = false;
        }
        //
        public IQueryable<AddressBook> GetAddressBooks()
        {
            return _Ctx.Context.AddressBooks;
        }

        public bool AddAddressBook(string Name, string LastName, string Address, string userType)
        {

            _Ctx.Context.AddressBooks.Add(new AddressBook
            {
                Name = Name,
                LastName = LastName,
                Address = Address,
                TypeUser = userType,
            });
            _Ctx.Context.SaveChanges();
            return true;
        }
        //
        public void Dispose()
        {
            if (_Ctx != null)
                _Ctx.Dispose();
        } 
        public bool IsAddressBookExist(string Name, string LastName)
        {
            throw new NotImplementedException();
        }
    }
}
