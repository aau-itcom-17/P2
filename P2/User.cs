using System;
namespace P2
{
    public class User
    {
        public string firstName{ get; set; }
        public string lastName{ get; set; }
        public string username{ get; set; }
        public string email { get;  set; }
        public string password{ get; set; }
        public string photoFileName{ get; set; }
        public int id{ get; set; }


        public User()
        {

        }
        public User(string firstName, string lastName, string username, string email, string password, string photoFileName, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.email = email;
            this.password = password;
            this.photoFileName = photoFileName;
            this.id = id;
        }



     


    }
}
