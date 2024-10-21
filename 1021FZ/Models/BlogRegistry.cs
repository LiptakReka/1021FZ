namespace _1021FZ.Models
{
    public class BlogRegistry
    {
        public int id { get; set; }
        public string Title { get; set; }
        public DateTime createdat { get; set; }
        public DateTime updatedat { get; set; }
        public string description { get; set; }


        public ICollection<Blogger> Blogs { get; set; }
    }
}
