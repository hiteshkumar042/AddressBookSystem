namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================\nWelcome To Address Book System\n===============================");
            Console.WriteLine("\n1. Add New Contact.\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                //UC1 - Add a New Contact
                case 1:
                    AddressBook.CreateContacts();
                    break;
                default:
                    Console.WriteLine("Choose from given option only!\n");
                    break;
            }
        }
    }
}