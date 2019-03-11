using System;
using System.Collections.Generic;
  public class AddressBook
  {
  //Add the required classes to make the following code compile.
  // HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.
    public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();

    //Method to get contacts by email. Takes in the string email 
    public Contact GetByEmail(string email) {

        Contact contactToReturn = Contacts[email];
        //will return contacts that correlate to the contact obj in addressbook
        return contactToReturn;
    }
    //Method to add Contacts to the addressbook.
    public void AddContact(Contact contact){
      try{
        //The key will be the contacts emailn address the value will be the rest of that contact address.
        //'try' to add the contact to the book for successful additions Console.WriteLine a success message
        Contacts.Add(contact.Email, contact);
        Console.WriteLine($"{contact.FullName} has been added to addressbook.");
      }
      //Threw and arguement exception due to trying to add sue twice in program.cs
      //Catch the argument Exception
      catch(ArgumentException){
        //printing a helpful comment to show the user they have already added that user to their book.
        Console.WriteLine($"{contact.FullName} is already in the addressbook");
      } 
    }
  }

