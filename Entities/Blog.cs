using System;
namespace BlogApp.Entities
{
    public class Blog
    {
        public Blog()
        {
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
