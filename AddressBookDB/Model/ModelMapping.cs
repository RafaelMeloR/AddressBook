using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDB.Model
{
    public class ModelMapping
    {
        public AddressBooks LoadAddressBook(AddressBookDB.AddressBook addr)
        { 
                return new AddressBooks
                {
                    Id = addr.Id,
                    Name = addr.Name,
                    LastName = addr.LastName,
                    FullName = addr.Name.Trim() + " " + addr.LastName.Trim(),
                    TypeUser = addr.TypeUser,
                    Address = addr.Address
                }; 
        }
        public AddressBooks LoadAddressBookStudent(AddressBookDB.AddressBook addr)
        {
             if (addr.TypeUser == "Student")
            {
                return new AddressBooks
                {
                    Id = addr.Id,
                    Name = addr.Name,
                    LastName = addr.LastName,
                    FullName = addr.Name.Trim() + " " + addr.LastName.Trim(),
                    TypeUser = addr.TypeUser,
                    Address = addr.Address
                };
            }
            return new AddressBooks { };
        }
        public AddressBooks LoadAddressBookTeacher(AddressBookDB.AddressBook addr)
        {
            if (addr.TypeUser == "Teacher")
            {
                return new AddressBooks
                {
                    Id = addr.Id,
                    Name = addr.Name,
                    LastName = addr.LastName,
                    FullName = addr.Name.Trim() + " " + addr.LastName.Trim(),
                    TypeUser = addr.TypeUser,
                    Address = addr.Address
                };
            }
            return new AddressBooks { };
        }

        public AddressBooks GetAddressBook(AddressBookDB.AddressBook addr)
        {
            return new AddressBooks
            {
                Id = addr.Id, 
                FullName = addr.Name.Trim() + " " + addr.LastName.Trim(),
                TypeUser = addr.TypeUser,
                Address = addr.Address
            };
        }

        public AddressBooks GetAddressBookTeacher(AddressBookDB.AddressBook addr)
        {
            if (addr.TypeUser == "Teacher")
            {
                return new AddressBooks
                {
                    Id = addr.Id,
                    FullName = addr.Name.Trim() + " " + addr.LastName.Trim(),
                    TypeUser = addr.TypeUser,
                    Address = addr.Address
                };
            }

            return null;
        }
    }
}
