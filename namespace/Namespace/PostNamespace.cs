using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostNamespace
{
    public class Post
    {

        public int id { get; set; }
        public string Content { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int LikeCount { get; set; }
        public int ViewCount { get; set; }
        public Post(int id, string content, DateTime creationDateTime, int likeCount, int viewCount)
        {
            this.id = id;
            Content = content;
            CreationDateTime = creationDateTime;
            LikeCount = likeCount;
            ViewCount = viewCount;
        }
        public override string ToString()
        {
            return $"Id :{id}\n" +
                $"Content : {Content}\n" +
                $"CreationDateTime : {CreationDateTime}\n" +
                $"LikeCount :{LikeCount}\n" +
                $"ViewCount :{ViewCount}";
        }
       
    }
}
