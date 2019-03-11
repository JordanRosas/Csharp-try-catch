using System;
using System.Collections.Generic;
public class Contact
    {
        //Created a Contact contructor 
        public Contact(string firstName, string lastName, string email, string address){
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            FullName = $"{FirstName} {LastName}";
        }
        //Properties of the Contact Class
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Address {get; set;}
        public string FullName {get; set;}
    
    }
class Program
{
    static void Main(string[] args)
    {
        // Create a few contacts utilizing the constructor
        Contact bob = new Contact("Bob", "Smith", "bob.smith@email.com", "100 Some ln Testville, TN 11111");
        Contact sue = new Contact("Sue", "Jones", "sue.jones@email.com", "322 Hard Way, Testville, TN 11111");
        Contact juan = new Contact("Juan", "Lopez", "juan@someEmail.com", "888 EasyVille, Testville, TN 12341");



        // Create an AddressBook and add some contacts to it
        AddressBook addressBook = new AddressBook();

        //Adding each of the Contacts from above to the address book (Dictionaary)
        addressBook.AddContact(bob);
        addressBook.AddContact(sue);
        addressBook.AddContact(juan);

        // Try to adda  contact a second time
        //Will likely throw an error becuase we dont want to add the same contact twice will print message at bottom
        addressBook.AddContact(sue);

        // Create a list of emails that match our Contacts
        List<string> emails = new List<string>() {
            "sue.jones@email.com",
            "juan.lopez@email.com",
            "bob.smith@email.com",
        };

        // Insert an email that does NOT match a Contact
        //Will likely throw an error becuase we dont want to add the same contact twice will print message at bottom
        emails.Insert(1, "not.in.addressbook@email.com");

        //  Search the AddressBook by email and print the information about each Contact
        foreach (string email in emails)
        {
        /*
        Add try/catch blocks to prevent the program from crashing
            Print meaningful error messages in the catch blocks.
        */ 
            try{
            Contact contact = addressBook.GetByEmail(email);
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Name: {contact.FullName}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine($"Address: {contact.Address}");
            }
            catch(KeyNotFoundException){
                Console.WriteLine("You are trying to add the same contact more than once.");
            }
        }
    }
}
