using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models {
public class OrderDetail
{
    public int OrderDetailId { get; set; }

    // FK Order
    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;

    // FK Product
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;

    [Range(1, 1000)]
    public int Quantity { get; set; }

    public decimal Price { get; set; }
}
}