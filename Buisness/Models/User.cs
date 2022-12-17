using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Models
{
    public enum Role
    {
        User,
        Admin
    }

    public class User
    {
        public readonly int Id;
        public string Name;
        public string Username;
        public string Password;
        public Role Role;



        public void RequestSupport()
        {
            Console.WriteLine("Ожидайте звонка.");
        }
    }
}
