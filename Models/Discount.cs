using System;
using System.Collections.Generic;

namespace BOOK_STORE_PORTAL_Project_.Models;

public partial class Discount
{
    public string? Dicounttype { get; set; }

    public int? StorId { get; set; }

    public int? Lowqty { get; set; }

    public int? Highqty { get; set; }

    public decimal? Discount1 { get; set; }

    public virtual Store? Stor { get; set; }
}
