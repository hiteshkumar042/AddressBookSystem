namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            while (true)
            {
                Console.WriteLine("===============================\nWelcome To Address Book System\n===============================");
                Console.WriteLine("\n1. Create Contact.\n2. Display Contact.\n3. Edit Existing Contact.\n4. Delete Contact.\n5. Add Multiple Address Book");
                int option = Convert.ToInt32(Console.ReadLine());
            
                switch (option)
                {
                    //UC1 - Create Contact
                    case 1:                  
                         addressBook.CreateContacts();
                        break;
                    //UC2 - Add Contact and Display
                    case 2:
                        addressBook.DisplayContact();
                        break;
                    //UC3 - Exit Existing Contact
                    case 3:
                        addressBook.EditContact();
                        break;
                    case 4:
                        //Uc4- Delete Contact
                        addressBook.DeleteContact();
                        break;
                    case 5:
                        //Uc6- Add Address Book
                        addressBook.AddNewAddressBook();
                        break;
                    default:
                        Console.WriteLine("Choose from given option only!\n");
                        break;
                }
            }
            
        }
    }
}
