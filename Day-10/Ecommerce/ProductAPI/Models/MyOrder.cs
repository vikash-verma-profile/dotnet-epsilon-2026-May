using System;
using System.Collections.Generic;

namespace ProductAPI.Models;

public partial class MyOrder
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? ProductCategory { get; set; }

    public decimal? ProductPrice { get; set; }
}
