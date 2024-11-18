using System;
using System.Collections.Generic;

namespace BOOK_STORE_PORTAL_Project_.Models;

public partial class Roysched
{
    public int? TitleId { get; set; }

    public decimal? Lorange { get; set; }

    public decimal? Hirange { get; set; }

    public decimal? Royalty { get; set; }

    public virtual Title? Title { get; set; }
}
