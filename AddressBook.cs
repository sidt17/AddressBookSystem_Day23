using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    class AddressBook
    {
        private List<Contact> contactList;
        public AddressBook()
        {
            contactList = new List<Contact>();
        }
        public void addContacts(string fistName, string lastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            //Create object of Contact class
            Contact contact = new Contact();
            //calling Varivale using object
            contact.FirstName = fistName;
            contact.LastName = lastName;
            contact.Address = address;
            contact.City = city;
            contact.State = state;
            contact.ZipCode = zip;
            contact.PhoneNumber = phoneNumber;
            contact.Email = email;
            //adding contact details in contact list 
            contactList.Add(contact);
        }
        //method print
        public void print()
        {
            //using foreach loop for calling the variable 
            foreach (Contact contact in contactList)
            {
                //Prinitng the Op
                Console.WriteLine("FirstName: " + contact.FirstName);
                Console.WriteLine("LastName: " + contact.LastName);
                Console.WriteLine("Address: " + contact.Address);
                Console.WriteLine("City: " + contact.City);
                Console.WriteLine("State: " + contact.State);
                Console.WriteLine("Zip: " + contact.ZipCode);
                Console.WriteLine("PhoneNumber: " + contact.PhoneNumber);
                Console.WriteLine("Email id: " + contact.Email);
            }
        }
        public void edit(string firstName, string lastName)
        {
            // created object ContacttobeEdited fir conatct and at starting it will be null
            Contact contactToBeEdited = null;

            // foreach loop begin
            // it will run till the
            // last element of the array
            foreach (Contact contact in this.contactList)
            {
                if (contact.FirstName == firstName && contact.LastName == lastName)
                    contactToBeEdited = contact;
            }
            // if First Name And last name is not match with entered data
            //contactToBeEdited == null
            if (contactToBeEdited == null)
            {
                //Error :No such contact exists
                Console.WriteLine("No such contact exists");
                return;
            }
            //otherwise get the value
            this.editThisContact(contactToBeEdited);
        }
        public void editThisContact(Contact contactToBeEdited)
        {
            //if true
            while (true)
            {
                //Enter what you want to edit
                Console.WriteLine("Enter 1 to edit FirstName");
                Console.WriteLine("Enter 2 to edit LastName");
                Console.WriteLine("Enter 3 to edit Address");
                Console.WriteLine("Enter 4 to edit City");
                Console.WriteLine("Enter 5 to edit State");
                Console.WriteLine("Enter 6 to edit Zip");
                Console.WriteLine("Enter 7 to edit PhoneNumber");
                Console.WriteLine("Enter 8 to edit Email Id");
                Console.WriteLine("Enter 9 if Editing is done");
                Console.WriteLine("Enter 10 if Delete is done");

                //read value
                int choice = Convert.ToInt32(Console.ReadLine());
                //switchCase
                switch (choice)
                {
                    //for Edit FirstName
                    case 1:
                        Console.WriteLine("Enter new FirstName");
                        string fName = Console.ReadLine();
                        contactToBeEdited.FirstName = fName;
                        break;
                    //For edit Lastlame
                    case 2:
                        Console.WriteLine("Enter new LastName");
                        string lName = Console.ReadLine();
                        contactToBeEdited.LastName = lName;
                        break;
                    //For Edit Address
                    case 3:
                        Console.WriteLine("Enter new Address");
                        string address = Console.ReadLine();
                        contactToBeEdited.Address = address;
                        break;
                    //For Edit City
                    case 4:
                        Console.WriteLine("Enter new City");
                        string city = Console.ReadLine();
                        contactToBeEdited.City = city;
                        break;
                    //For Edit State
                    case 5:
                        Console.WriteLine("Enter new State");
                        string state = Console.ReadLine();
                        contactToBeEdited.State = state;
                        break;
                    //For Edit Zip
                    case 6:
                        Console.WriteLine("Enter new Zip");
                        int zip = Convert.ToInt32(Console.ReadLine());
                        contactToBeEdited.ZipCode = zip;
                        break;
                    ////For Edit Phone NUmber
                    case 7:
                        Console.WriteLine("Enter new PhoneNumber");
                        long phoneNumber = long.Parse(Console.ReadLine());
                        contactToBeEdited.PhoneNumber = phoneNumber;
                        break;
                    //For Edit Email ID
                    case 8:
                        Console.WriteLine("Enter new Email Id");
                        string email = Console.ReadLine();
                        contactToBeEdited.Email = email;
                        break;
                    //if Done
                    case 9:
                        Console.WriteLine("Editing done.New Contact :-");
                        this.printSpecificContact(contactToBeEdited);
                        return;

                }
            }
        }
        //Print Data After Edit
        public void printSpecificContact(Contact contact)
        {
            Console.WriteLine("FirstName: " + contact.FirstName);
            Console.WriteLine("LastName: " + contact.LastName);
            Console.WriteLine("Address: " + contact.Address);
            Console.WriteLine("City: " + contact.City);
            Console.WriteLine("State: " + contact.State);
            Console.WriteLine("Zip: " + contact.ZipCode);
            Console.WriteLine("PhoneNumber: " + contact.PhoneNumber);
            Console.WriteLine("Email id: " + contact.Email);
        }
        public void Delete(string firstName, string lastName)
        {
            Contact contactToBeDeleted = null;
            foreach (Contact contact in this.contactList)
            {
                if (contact.FirstName == firstName && contact.LastName == lastName)
                {
                    contactToBeDeleted = contact;
                    this.contactList.Remove(contactToBeDeleted);
                    break;
                }
            }
            if (contactToBeDeleted == null)
                Console.WriteLine("No such contact exists");
            else
                Console.WriteLine("Deletion Done.");
        }

    }
}