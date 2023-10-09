using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class CopieTable
{
    public int Id { get; set; }

    public string CodeArticle { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public decimal Quantite { get; set; }

    public decimal PrixUnitaire { get; set; }
}
