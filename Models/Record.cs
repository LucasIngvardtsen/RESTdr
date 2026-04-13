namespace RESTdr.Models
{
    public class Record
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public int PublicationYear { get; set; }

        public Record() { }
        public Record(string title, string artist, double duration, int publicationYear)
        {
            Id = Id++;
            Title = title;
            Artist = artist;
            Duration = duration;
            PublicationYear = publicationYear;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Artist: {Artist}, Duration: {Duration} minutes, Publication Year: {PublicationYear}";
        }
    }

    
}
