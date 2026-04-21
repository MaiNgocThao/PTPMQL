using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models {
public class Order
{
    public int OrderId { get; set; }

    [Required]
    public DateTime OrderDate { get; set; }

    // FK
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

   public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
}