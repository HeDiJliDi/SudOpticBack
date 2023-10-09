using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueLigneFactureAchatDiver
{
    public string NumeroAchatDiver { get; set; } = null!;

    public int NumeroOrdre { get; set; }

    public string DesignationArticle { get; set; } = null!;

    public decimal NetHt { get; set; }

    public decimal TauxTva { get; set; }

    public decimal MontantTva { get; set; }

    public decimal MontantTtc { get; set; }

    public string Observation { get; set; } = null!;
}
