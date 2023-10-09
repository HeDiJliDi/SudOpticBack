using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class UniteArticle
{
    public string CodeUnite { get; set; } = null!;

    public string Libelle { get; set; } = null!;

    public int NombreDecimal { get; set; }
}
