using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal interface IContact
    {
        void CreateContacts();
        void DisplayContact();
        void EditContact();
        void DeleteContact();
        void AddNewAddressBook();
    }
}
