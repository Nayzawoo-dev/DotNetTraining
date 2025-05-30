using System;
using System.Collections.Generic;

namespace Efcoretest2.Models;

public partial class TblHomeWork
{
    public int RollNo { get; set; }

    public string Name { get; set; } = null!;

    public string? GitHubUserName { get; set; }

    public string? GitHubRepoLink { get; set; }
}
