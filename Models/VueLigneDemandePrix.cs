using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueLigneDemandePrix
{
    public string NumeroDemandePrix { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public int NumeroOrdre { get; set; }

    public decimal Quantite { get; set; }

    public string Observation { get; set; } = null!;
}
