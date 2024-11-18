using System;
using System.Collections.Generic;

namespace BOOK_STORE_PORTAL_Project_.Models;

public partial class Job
{
    public int JobId { get; set; }

    public string? JobDesc { get; set; }

    public string? MinLvl { get; set; }

    public string? MaxLvl { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
