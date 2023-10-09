using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class LigneDemandePrix
{
    public string NumeroDemandePrix { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string DesignationArticle { get; set; } = null!;

    public int NumeroOrdre { get; set; }

    public decimal Quantite { get; set; }

    public string Observation { get; set; } = null!;
}
