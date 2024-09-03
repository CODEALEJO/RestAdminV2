using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestAdminV2.Models;

[Table("order_details")]
public class OrderDetails
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("id_ordered")]
    [Required(ErrorMessage = "The order ID is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "The order ID must be a positive number.")]
    public int IdOrdered { get; set; }

    [Column("id_product")]
    [Required(ErrorMessage = "The product ID is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "The product ID must be a positive number.")]
    public int IdProduct { get; set; }

    [Column("quantity")]
    [Required(ErrorMessage = "The quantity is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "The quantity must be a positive number greater than zero.")]
    public int Quantity { get; set; }

    [Column("unit_price")]
    [Required(ErrorMessage = "The unit price is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "The unit price must be a positive number greater than zero.")]
    [DataType(DataType.Currency, ErrorMessage = "The unit price must be in a valid currency format.")]
    public double UnitPrice { get; set; }
    

    //Foreing Links
    [ForeignKey("IdOrdered")]
    public Ordered? Ordered { get; set; }

    [ForeignKey("IdProduct")]
    public Product? Product { get; set; }

}
