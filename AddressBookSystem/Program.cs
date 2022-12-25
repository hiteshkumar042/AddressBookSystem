namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================\nWelcome To Address Book System\n===============================");
            Console.WriteLine("\n1. Create Contact\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                //UC1 - Create Contact
                case 1:
                    CreateContacts();
                    break;
                default:
                    Console.WriteLine("Choose from given option only!\n");
                    break;
            }
        }
        public static void CreateContacts()
        {
            //reading data and storing in set method/properties 
            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine();
            //Last Name 
            Console.Write("Enter Last Name : ");
            string lastName = Console.ReadLine();
            //Address
            Console.Write("Enter Address : ");
            string address = Console.ReadLine();
            //City
            Console.Write("Enter City Name : ");
            string city = Console.ReadLine();
            //State Name 
            Console.Write("Enter State Name : ");
            string state = Console.ReadLine();
            //ZIP Code
            Console.Write("Enter ZIP Code : ");
            int ZIPCode = Convert.ToInt32(Console.ReadLine());
            //Phone Number
            Console.Write("Enter Phone Number : ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            //Email Id :
            Console.Write("Enter Email Id : ");
            string email = Console.ReadLine();
        }
    }
}