using System;
using System.Collections.Generic;

namespace DBFirstApproach.Models;

public partial class TblStudent
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Gender { get; set; }

    public string? Age { get; set; }
}
