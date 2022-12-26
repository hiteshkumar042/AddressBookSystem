namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================\nWelcome To Address Book System\n===============================");
            Console.WriteLine("\n1. Create Contact.\n2. Add Contact and Display\n3. Edit Existing Contact\n");
            int option = Convert.ToInt32(Console.ReadLine());
            AddressBook addressBook = new AddressBook();
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
                default:
                    Console.WriteLine("Choose from given option only!\n");
                    break;
            }
        }
    }
}