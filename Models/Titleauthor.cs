using System;
using System.Collections.Generic;

namespace BOOK_STORE_PORTAL_Project_.Models;

public partial class Titleauthor
{
    public int? AuId { get; set; }

    public int? TitleId { get; set; }

    public string? AuOrd { get; set; }

    public string? Royaltyper { get; set; }

    public virtual Author? Au { get; set; }

    public virtual Title? Title { get; set; }
}
