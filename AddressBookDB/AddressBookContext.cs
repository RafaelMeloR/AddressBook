using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDB
{
    public class AddressBookContext
    {
        AddressBookEntities _Ctx;

        public AddressBookContext()
        {
            _Ctx = new AddressBookEntities();
        }

        public AddressBookEntities Context
        {
            get
            {
                return this._Ctx;
            }
        }

        public void Dispose()
        {
            if (_Ctx != null)
                _Ctx.Dispose();
        }
    }
}
