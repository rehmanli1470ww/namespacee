using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostNamespace;
namespace UserNamespace
{
    public class User
    {

        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public List<Post> posts { get; set; }
        public User(int id, string name, string surname, int age, string email, string password)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.email = email;
            this.password = password;
            posts = new List<Post> ();
        }
        public override string ToString()
        {
            int i = 0;
            return $"Id :{id}\n" +
                $"Name : {name}\n" +
                $"Surname :{surname}\n" +
                $"Age :{age}\n" +
                $"Email : {email}\n" +
                $"Post \n" +
                $" {posts[i++].ToString() }";
        }
        public void post()
        {
            int idd = 0;
            Console.WriteLine(
                $"Name : {name}\n" +
                $"Surname :{surname}\n" +
                $"Posdu \n{posts[idd++].ToString()}");
            
        }
        
       
    }
}
