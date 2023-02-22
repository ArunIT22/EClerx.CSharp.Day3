using System;

namespace EClerx.CSharp.Day3
{
    //public class ContactDetails
    //{
    //    public object[] Contacts { get; set; }
    //    public int Size { get; set; }
    //    public int Index { get; set; }

    //    public ContactDetails(int size)
    //    {
    //        this.Size = size;
    //        this.Contacts = new object[size];
    //        Index = 0;
    //    }

    //    public void AddContact(object contact)
    //    {
    //        if (Index < Size)
    //        {
    //            Contacts[Index++] = contact;
    //        }
    //    }

    //    public object GetContact(int index)
    //    {
    //        return Contacts[index];
    //    }

    //    static void Main1(string[] args)
    //    {
    //        ContactDetails mobile = new ContactDetails(3);
    //        ContactDetails email = new ContactDetails(3);

    //        mobile.AddContact(7894561231);
    //        mobile.AddContact(7894561232);
    //        mobile.AddContact(7894561233);

    //        email.AddContact("tim@gmail.com");
    //        email.AddContact("john@gmail.com");
    //        email.AddContact("pravin@gmail.com");

    //        Random random = new Random();
    //        var luckyNo = random.Next(0, 3);

    //        long selectedMobileNo = (long)mobile.GetContact(luckyNo);
    //        string selectedEmailId = (string)email.GetContact(luckyNo);

    //        Console.WriteLine($"Select Mobile No :{selectedMobileNo}");
    //        Console.WriteLine($"Select Email Id :{selectedEmailId}");

    //        Console.WriteLine();

    //        ContactDetails contacts = new ContactDetails(6);
    //        contacts.AddContact(7894561231);
    //        contacts.AddContact("john@gmail.com");
    //        contacts.AddContact(7894561232);
    //        contacts.AddContact("kumar@gmail.com");
    //        contacts.AddContact(7894561233);
    //        contacts.AddContact("karthick@gmail.com");

    //        var newLuckyNo = random.Next(0, 5);

    //        long newSelectedMobileNo = (long)contacts.GetContact(newLuckyNo);

    //        Console.WriteLine($"Selected :{newSelectedMobileNo}");

    //        Console.ReadLine();
    //    }
    //}
}
