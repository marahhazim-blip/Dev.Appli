using System;
using System.Collections.Generic;
using System.Text;

namespace BlogConsole.Models
{
    internal class Comment
        {
            public int Id { get; set; }
            public int ArticleId { get; set; }
            public string Author { get; set; }
            public string Content { get; set; }
            public DateTime CreatedAt { get; set; }

            //public Comment()
            //{
            //    CreatedAt = DateTime.Now;
            //}

            //public override string ToString()
            //{
            //    return $"{Author} : {Content}";
            //}
        }
    }




