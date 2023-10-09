using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Tracabilite
{
    public int Id { get; set; }

    public string? NomTable { get; set; }

    public string? TypeAction { get; set; }

    public bool? Vue { get; set; }
}
