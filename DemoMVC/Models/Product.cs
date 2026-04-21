using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models {
public class Product
{
    public int ProductId { get; set; }

    [Required]
    [StringLength(200)]
    public string? ProductName { get; set; }

    [Range(0, 100000000)]
    public decimal Price { get; set; }

    public ICollection<OrderDetail>? OrderDetails { get; set; }
}
}