using System;
using System.Collections.Generic;

namespace EfDatabase.Models;

public partial class TblWindow
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }
}
