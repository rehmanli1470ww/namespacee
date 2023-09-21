using Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PostNamespace;


namespace AdminNamespace
{
    public class Admin
    {

        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public List<Post> posts { get; set; }
        public List<Notifications> notifications { get; set; }
        
        public Admin(int id, string username, string email, string password)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.password = password;
            posts = new List<Post>();
            notifications =  new List<Notifications>();

        }
        public override string ToString()
        {
            int i = 0;
            return $"Id :{id}\n" +
                 $"Username : {username}\n" +
                 $"Email : {email}\n" +
                 $"Post : {posts}\n" +
                 $"Notifications \n" +
                 $"{notifications[i++].ToString()}";
           
        }
        public void post()
        {
            int idd = 0;
            Console.WriteLine(
                $"Name : {username}\n" +
                $"Posdu \n{posts[idd++].ToString()}");

        }
        public void notificatioo() {
            Console.WriteLine("\nGelen mailler\n");
            for (int i = 0; i < notifications.Count(); i++)
            {
                Console.WriteLine("\n"+notifications[i].ToString());
            }
        }

    }
}
