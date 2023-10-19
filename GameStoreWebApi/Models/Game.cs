using System.ComponentModel.DataAnnotations;

namespace GameStoreWebApi.Models
{
    public class Game
    {
        // public Product(string id, string productName, double productPrice)
        [Key]
        [Display(Name = "Id")]
        public string GameId { get; set; }

        // public string ProductName { get; set; }
        [Required]
        [Display(Name = "Title")]
        [StringLength(50)]
        public string GameTitle { get; set; }

        // public string ProductName { get; set; }
        [Required]
        [Display(Name = "Description")]
        [StringLength(50)]
        public string GameDescription { get; set; }

        // public double ProductPrice { get; set; }
        [Required]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        // public double ProductPrice { get; set; }
        [Required]
        [Display(Name = "Buy Price")]
        public double BuyPrice { get; set; }

        // public double ProductPrice { get; set; }
        [Required]
        [Display(Name = "Sell Price")]
        public double SellPrice { get; set; }
    }
}
