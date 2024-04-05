using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hms
{
    public class Users
    {
        private static int _idseed = 0;
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int ID { get; private set; }
        public Users(string name, string address, string email, int phoneNumber)
        {
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            ID = _idseed++;

        }

    }
}