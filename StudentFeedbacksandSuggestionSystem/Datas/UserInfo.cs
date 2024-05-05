using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFeedbacksandSuggestionSystem
{
    public class UserInfo
    {
        private int user_id, age;
        private string firstname, lastname, email, username, password, gender, role;

        public UserInfo() { }
        public UserInfo(int user_id, string firstname, string lastname, int age, string email, string username, string password, string gender, string role) 
        {
            this.user_id = user_id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.username = username;
            this.password = password;
            this.age = age;
            this.role = role;
        }

        public int User_id { get => user_id; set => user_id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Age { get => age; set => age = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Role { get => role; set => role = value; }

    }
}
