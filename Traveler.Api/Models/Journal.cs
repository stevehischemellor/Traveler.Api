namespace Traveler.Api.Models
{
    public class Journal
    {
        public Journal() 
        {
            this.Entries = new List<Entry>();
            this.Photos = new List<Photo>();
        }
        
        public DateTime StartDate { get; set; }
        public  DateTime EndDate { get; set; }
        public string? Title { get; set; }
        public List<Entry> Entries { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
