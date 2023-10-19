namespace GameStoreWebApi.Models
{
    public class Review
    {
        // public Product(string id, string productName, double productPrice)
        public int ReviewId { get; set; }
        public string ReviewTitle { get; set; } = null!;
        public string ReviewText { get; set; } = null!;
        public int ReviewScore { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }
        

    }
}
