namespace LOP_FULLSTACK.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string User { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int PhotoId { get; set; }
    }
}
