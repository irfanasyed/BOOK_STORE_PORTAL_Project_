using System;
using System.Collections.Generic;

namespace BOOK_STORE_PORTAL_Project_.Models;

public partial class Sale
{
    public int? StorId { get; set; }

    public int OrdNum { get; set; }

    public DateTime? OrdDate { get; set; }

    public int? Qty { get; set; }

    public string? Payterms { get; set; }

    public int? TitleId { get; set; }

    public virtual Store? Stor { get; set; }

    public virtual Title? Title { get; set; }
}
