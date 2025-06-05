using System.ComponentModel.DataAnnotations;

namespace QLSP.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên sản phẩm không được để trống.")]
        [MaxLength(100, ErrorMessage = "Tên sản phẩm không được vượt quá 100 ký tự.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Giá sản phẩm không được để trống.")]
        [Range(0.01, 999999999.99, ErrorMessage = "Giá sản phẩm phải là số dương và có giá trị hợp lệ.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Tồn kho không được để trống.")]
        [Range(0, 99999, ErrorMessage = "Số lượng tồn kho phải là số nguyên không âm.")]
        public int Stock { get; set; }
    }
}
