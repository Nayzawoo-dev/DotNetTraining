using System;
using System.Collections.Generic;

namespace EfDatabase.Models;

public partial class TblProductlist
{
    public int ProductId { get; set; }

    public string? ProductCode { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public string CreatedByName { get; set; } = null!;

    public DateTime? ModifiedDateTime { get; set; }

    public int? ModifiedBy { get; set; }

    public int? CreatedById { get; set; }
}
