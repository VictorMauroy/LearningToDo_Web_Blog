namespace Learning_Blog.Models.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string DisplayName { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
