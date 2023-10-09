using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class LigneBonTransformation
{
    public string NumeroBonTransformation { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public decimal Quantite { get; set; }
}
