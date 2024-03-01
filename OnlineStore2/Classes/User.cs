using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore2.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(int id, string name, string address, string email, string password)
        {
            Id = id;
            Name = name;
            Address = address;
            Email = email;
            Password = password;
        }

    }
}
