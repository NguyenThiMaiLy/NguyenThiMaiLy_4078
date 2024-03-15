using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NguyenThiMaiLy_4078.Models
{
    public class Product
    {
        [Required]
        [DisplayName("Mã sản phẩm")]
        public int Id { get; set; }
        [Required, StringLength(100)]
        [DisplayName("Tên sản phẩn")]
        public string Name { get; set; }
        [Range(0.01, 10000.00)]
        [DisplayName("Giá")]
        public decimal Price { get; set; }
        [DisplayName("Mô tả")]
        public string Description { get; set; }
        public string? ImageUrl { get; set; } 
        public List<string>? ImageUrls { get; set; } 
        
   
}
}
