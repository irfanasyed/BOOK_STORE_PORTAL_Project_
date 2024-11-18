using System;
using System.Collections.Generic;

namespace BOOK_STORE_PORTAL_Project_.Models;

public partial class PubInfo
{
    public int? PubId { get; set; }

    public string? Logo { get; set; }

    public string? PrInfo { get; set; }

    public virtual Publisher? Pub { get; set; }
}
