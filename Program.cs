using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Contact list = new Contact();

            Console.Write("Enter First Name: ");
            list.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            list.LastName = Console.ReadLine();

            Console.Write("Enter Address : ");
            list.Address = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            list.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            list.Email = Console.ReadLine();

        }

    }

}

