using System;
using System.Data;
using CavemanTools.Model;

namespace Tests
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public IdName Author { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        public PostType Type { get; set; }
        public IdName Topic { get; set; }
    }

}