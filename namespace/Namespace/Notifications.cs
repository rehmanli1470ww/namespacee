using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostNamespace;
namespace Notification
{
    public class Notifications
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Notifications(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
        public override string ToString()
        {
            return $"Id: {id}" +
                $"\nName: {name}" +
                $"\ndescription: {description}";
        }

    }
}
