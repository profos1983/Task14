using System;
using System.Collections.Generic;
using System.Text;

namespace Task15_3_3.Classes
{
    public class Contact
    {
        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
