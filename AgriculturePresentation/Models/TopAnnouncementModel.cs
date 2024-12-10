namespace AgriculturePresentation.Models
{
    public class TopAnnouncementModel
    {
        public int TopAnnouncementId { get; set; }
        public string Title { get; set; }
        public string Imageurl { get; set; }
        public string Description { get; set; }
        public string MinDescription { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
