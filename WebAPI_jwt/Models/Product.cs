using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPI_jwt.Models;

public partial class Product
{
    [Key]
    public int ProductId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Category { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Color { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal UnitPrice { get; set; }

    public int AvailableQuantity { get; set; }
}
