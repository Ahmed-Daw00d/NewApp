using System.ComponentModel.DataAnnotations;

namespace WepApp.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }=String.Empty;
        [Required]
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
    }
}
