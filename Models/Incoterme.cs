using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Incoterme
{
    public string CodeIncoterme { get; set; } = null!;

    public string? Libelle { get; set; }
}
