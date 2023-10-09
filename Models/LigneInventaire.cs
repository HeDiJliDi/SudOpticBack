using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class LigneInventaire
{
    public string NumeroInventaire { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public decimal AncienneQuantite { get; set; }

    public decimal NouvelleQuantite { get; set; }

    public decimal PrixInventaire { get; set; }

    public string Observation { get; set; } = null!;
}
