namespace Project
{
    public class ArtInspector : IPrintable
    {
        public int? Rating { get; set; }
        public ArtGallery ArtGallery { get; set; }
        public ArtInspector(ArtGallery restaurant, int? rating) 
        {
            Rating = rating;
            ArtGallery = restaurant;
        }
        public override string ToString()
        {
            string result;
            if (Rating == null)
            {
                result = $"Галерея: {ArtGallery.Name} - не оцiнена";
            }
            else 
                result = $"Галерея: {ArtGallery.Name}, рейтинг - {Rating}";
            return result;
        }
        public string PrintToDisplay()
        {
            string result;
            if (Rating == null)
            {
                result = $"Галерея: {ArtGallery.Name} - не оцiнена";
            }
            else
                result = $"Галерея: {ArtGallery.Name}, рейтинг - {Rating}";
            result += $"\n{ArtGallery.PrintToDisplay()}";
            return result;
        }
    }
}
