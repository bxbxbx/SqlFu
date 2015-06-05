using System;
using SqlFu;
using SqlFu.DDL;

namespace Tests
{
    [Table("Posts",CreationOptions = IfTableExists.Ignore)]
    class Post
    {
        public Post()
        {
            CreatedOn = DateTime.Now;
         
        }
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        //[InsertAsString]
        public PostType Type { get; set; }
        public int? TopicId { get; set; }
        public bool IsActive { get; set; }
        [QueryOnly]
        [ColumnOptions(DefaultValue = "99")]
        public int IgnoreWhenUpdate { get; set; }
        
    }
}