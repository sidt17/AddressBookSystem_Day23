using System;

namespace AddressBookProgram
{
    class AddressBook
    {
        public void Details()
        {
            Console.WriteLine("Which AddressBook do you want to Enter-  1 or 2");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                List<string> AddressBook = new List<string>();

                Console.WriteLine("Welcome to AddressBook 1");

                Console.Write("Enter First Name: ");
                AddressBook.Add(Console.ReadLine());

                Console.Write("Enter Last Name: ");
                AddressBook.Add(Console.ReadLine());

                Console.Write("Enter Address : ");
                AddressBook.Add(Console.ReadLine());

                Console.Write("Enter Phone Number: ");
                AddressBook.Add(Console.ReadLine());

                Console.Write("Enter Email: ");
                AddressBook.Add(Console.ReadLine());

                Console.WriteLine("The Details you added are-");

                foreach (string s in AddressBook)
                {
                    Console.WriteLine(s);
                }
               

            }
           

            else
            {
                HashSet<string> AddressBook2 = new HashSet<string>();
                Console.WriteLine("Welcome to AddressBook 2");

                Console.Write("Enter First Name: ");
                AddressBook2.Add(Console.ReadLine());

                Console.Write("Enter Last Name: ");
                AddressBook2.Add(Console.ReadLine());

                Console.Write("Enter Address : ");
                AddressBook2.Add(Console.ReadLine());

                Console.Write("Enter Phone Number: ");
                AddressBook2.Add(Console.ReadLine());

                Console.Write("Enter Email: ");
                AddressBook2.Add(Console.ReadLine());

                Console.WriteLine("The Details you added are-");

                foreach (string m in AddressBook2)
                {
                    Console.WriteLine(m);
                }
            } Console.WriteLine("Details added successfully");
        }
    }

}
