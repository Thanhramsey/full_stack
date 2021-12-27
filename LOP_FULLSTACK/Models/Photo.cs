namespace LOP_FULLSTACK.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string Title { get; set; }
        public string PhotoFile { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Owner { get; set; }


    }
}
