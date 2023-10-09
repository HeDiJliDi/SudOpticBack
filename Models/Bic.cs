using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Bic
{
    public string CodeBic { get; set; } = null!;

    public string? Libelle { get; set; }
}
