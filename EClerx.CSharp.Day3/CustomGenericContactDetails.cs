using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EClerx.CSharp.Day3
{
    public class ContactDetails<Type>
    {
        public Type[] Contacts { get; set; }
        public int Size { get; set; }
        public int Index { get; set; }

        public ContactDetails(int size)
        {
            this.Size = size;
            this.Contacts = new Type[size];
            Index = 0;
        }

        public void AddContact(Type contact)
        {
            if (Index < Size)
            {
                Contacts[Index++] = contact;
            }
        }

        public object GetContact(int index)
        {
            return Contacts[index];
        }

        static void Main1(string[] args)
        {
            ContactDetails<long> mobile = new ContactDetails<long>(3);
            ContactDetails<string> email = new ContactDetails<string>(3);

            mobile.AddContact(7894561231);
            mobile.AddContact(7894561232);
            mobile.AddContact(7894561233);

            email.AddContact("tim@gmail.com");
            email.AddContact("john@gmail.com");
            email.AddContact("pravin@gmail.com");

            Random random = new Random();
            var luckyNo = random.Next(0, 3);

            long selectedMobileNo = (long)mobile.GetContact(luckyNo);
            string selectedEmailId = (string)email.GetContact(luckyNo);

            Console.WriteLine($"Select Mobile No :{selectedMobileNo}");
            Console.WriteLine($"Select Email Id :{selectedEmailId}");

            Console.ReadLine();
        }
    }
}
