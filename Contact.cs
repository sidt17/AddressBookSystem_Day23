using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public long PhoneNumber { get; set; }

        public string Email { get; set; }

        public void NewDetails()
        {
            string FirstName;
            string LastName;
            string Address;
            string City;
            string State;
            int ZipCode;
            long PhoneNumber;
            string Email;

            Console.WriteLine("Enter your first name:");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter your address:");
            Address = Console.ReadLine();
            Console.WriteLine("Enter your city:");
            City = Console.ReadLine();
            Console.WriteLine("Enter your state:");
            State = Console.ReadLine();
            Console.WriteLine("Enter zip code:");
            ZipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phone number:");
            PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your email:");
            Email = Console.ReadLine();

            Console.WriteLine("Hello" + FirstName + " " + LastName + " your data has been saved");

        }



    }

    
}
    



