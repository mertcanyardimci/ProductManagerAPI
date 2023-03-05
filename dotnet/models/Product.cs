namespace dotnet.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int memberId { get; set; }
        public int cityId { get; set; }
        public string? CityName { get; set;}
        public string? TownName { get; set; }
        public string? ModelName { get; set; }
        public int Year { get; set; }
        public float Price { get; set; }
        public int Km { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        
    }
}