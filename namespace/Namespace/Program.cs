using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notification;
using PostNamespace;
using UserNamespace;
using AdminNamespace;
using SecimExcaptions;
using System.ComponentModel.Design;

namespace Namespace
{

    public class Program
    {
        public void Show()
        {

        }
       
        static void Main()
        {
            int likeUser1 = 0,ViewUser1=0;
            int likeUser2 = 0,ViewUser2=0;
            int likeUser3 = 0,ViewUser3=0;
            DateTime data;
            data = DateTime.Now;
            int likeadmin1 = 0,viewadmin1=0;
            int likeadmin2 = 0,viewadmin2=0;
            int likeadmin3 = 0,viewadmin3=0;
           
            Admin admin1 = new(1, "Haci", "Haci@mail.ru", "1234");
            admin1.posts.Add(new Post(1, "erfer", data, likeadmin1, viewadmin1));
            Admin admin2 = new(2, "Mehemmed", "Mehemmed@mail.ru", "1357");
            admin2.posts.Add(new Post(2, "erferdrfrf", data, likeadmin2, viewadmin2));
            Admin admin3 = new(3, "Eli", "Eli@mail.ru", "2468");
            admin3.posts.Add(new Post(3, "erfer", data, likeadmin3, viewadmin3));
            admin1.notifications.Add(new Notifications(2, "asdwer", "awersdf"));
            admin2.notifications.Add(new Notifications(2, "asdwer", "awersdf"));
            admin3.notifications.Add(new Notifications(2, "asdwer", "awersdf"));
            admin1.notifications.Add(new Notifications(3, "asdwer", "asdwerf"));
            admin2.notifications.Add(new Notifications(4, "asderew", "asdwerf"));
            admin3.notifications.Add(new Notifications(4, "asderew", "asdwerf"));
           

            User user1 = new(1, "Qulu", "Quluyev",25, "qulu@mail.ru", "12345");
            user1.posts.Add(new Post(1, "jhg", data, likeUser1, ViewUser1));
           
            User user2 = new(2, "Ersad", "Ersadli", 26, "Ersad@mail.ru", "54321");
            user2.posts.Add(new Post(2, "j", data, likeUser2, ViewUser2));
            
            User user3 = new(3, "Gulu", "Guluyeva",25, "gulu@mail.ru", "12545");
            user3.posts.Add(new Post(3, "jhwaer", data, likeUser3, ViewUser3));
           
            List<User> users = new List<User>();
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            List<Admin> admins = new List<Admin>();
            admins.Add(admin1);
            admins.Add(admin2);
            admins.Add(admin3);
            

            while (true) { 
                Console.WriteLine("1 Admin Giris\n2 User Giris \nSecim edin :");
                string ?Secim;
                Secim=Console.ReadLine();
                try
                {
                    if (Secim == "1")
                    {
                        string? adminn;
                        string? paswordd;
                        Console.WriteLine("Admin name-i daxil edin : ");
                        adminn=Console.ReadLine();
                        Console.WriteLine("Password-u daxil edin : ");
                        paswordd=Console.ReadLine();
                        
                        foreach (var item in admins)
                        {
                            if (paswordd == item.password && adminn==item.username) {
                                Console.WriteLine(item.username + "  Xos geldin\n\n");
                                Thread.Sleep(3000);
                                Console.Clear();
                                foreach (var item1 in admins)
                                {
                                    Console.WriteLine("Id :" + item1.id + "\n" +
                                        "Name : " + item1.username + "\n" +
                                        "Sorneme : " + item1.email + "\n\n");

                                }
                                Console.WriteLine("Posta baxmaq ucun id-ni daxil edin ");
                                string? idd;
                                idd = Console.ReadLine();
                                
                                Console.Clear();
                                admins[int.Parse(idd) - 1].posts[0].ViewCount++;
                                admins[int.Parse(idd) - 1].notifications.Add(new Notifications(item.id, item.username, "Baxis etdi"));
                                admins[int.Parse(idd) - 1].post();
                                admins[int.Parse(idd) - 1].notificatioo();
                                Console.WriteLine("\n\n1 Like etmek isdediyin Userin id-sini yaz \n" +
                                                    "0 Cixis");
                                string? idadd;
                                idadd = Console.ReadLine();
                                
                                Console.Clear();
                                if (idadd != "0")
                                {
                                    admins[int.Parse(idd) - 1].posts[0].LikeCount++;
                                    admins[int.Parse(idd)-1].notifications.Add(new Notifications(item.id, item.username, "Like etdi"));
                                    admins[int.Parse(idd) - 1].post();
                                    admins[int.Parse(idd) - 1].notificatioo();
                                }
                            }
                        }
                    }
                    else if (Secim == "2")
                    {
                        string? userr;
                        string? paswordd;
                        Console.WriteLine("User name-i daxil edin : ");
                        userr = Console.ReadLine();
                        Console.WriteLine("Password-u daxil edin : ");
                        paswordd = Console.ReadLine();
                        Console.WriteLine(userr +"  Xos geldin\n\n");
                        foreach (var item in users)
                        {
                            Console.WriteLine("Id :"+item.id+"\n" +
                                "Name : "+item.name + "\n" +
                                "Sorneme : " + item.surname + "\n\n");

                        }
                        Console.WriteLine("Posta baxmaq ucun id-ni daxil edin ");
                        string? idd;
                        idd = Console.ReadLine();
                        
                        Console.Clear();
                        users[int.Parse(idd) - 1].posts[0].ViewCount++;
                        users[int.Parse(idd) - 1].post();

                        Console.WriteLine("\n\n1 Like etmek\n" +
                            "0 Cixis");
                        string? idadd;
                        idadd = Console.ReadLine();
                        
                        Console.Clear();
                        if (idadd == "1")
                        {
                            users[int.Parse(idd) - 1].posts[0].LikeCount++;
                            users[int.Parse(idd) - 1].post();
                        }

                    }
                    else 
                    {
                        throw new secimExcaption() ;
                    }
                
                    
                }
                catch (secimExcaption ex)
                {
                    Console.WriteLine(ex.Message);
                }

                
            }

        }



    }
}

/*
 *  string? userr;
                        string? paswordd;
                        Console.WriteLine("User name-i daxil edin : ");
                        userr = Console.ReadLine();
                        Console.WriteLine("Password-u daxil edin : ");
                        paswordd = Console.ReadLine();

                        foreach (var item in users)
                        {
                            Console.WriteLine("Id :"+item.id+"\n" +
                                "Name : "+item.name + "\n" +
                                "Sorneme : " + item.surname + "\n\n");

                        }
                        Console.WriteLine("Posta baxmaq ucun id-ni daxil edin ");
                        string? idd;
                        idd = Console.ReadLine();
                        users[int.Parse(idd) - 1].posts[0].ViewCount++;
                        users[int.Parse(idd) - 1].post();

                        Console.WriteLine("\n\n1 Like etmek isdediyin Userin id-sini yaz \n" +
                            "0 Cixis");
                        string? idadd;
                        idadd = Console.ReadLine();
                        if (idadd != "0")
                        {
                            users[int.Parse(idadd) - 1].posts[0].LikeCount++;
                            users[int.Parse(idadd) - 1].post();
                        }
 * 
 */