using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueLigneBonRetourAchat
{
    public string NumeroBonRetourAchat { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public decimal Quantite { get; set; }

    public decimal PrixAchatHt { get; set; }

    public decimal MontantHt { get; set; }

    public decimal TauxRemise { get; set; }

    public decimal MontantRemise { get; set; }

    public decimal MontantFodec { get; set; }

    public decimal NetHt { get; set; }

    public decimal TauxTva { get; set; }

    public decimal MontantTva { get; set; }

    public decimal MontantTtc { get; set; }

    public string Observation { get; set; } = null!;

    public int NumeroOrdre { get; set; }
}
