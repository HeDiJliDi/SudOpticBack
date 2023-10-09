using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueLigneFactureVente
{
    public string NumeroFactureVente { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public decimal PrixVenteHt { get; set; }

    public decimal Quantite { get; set; }

    public decimal MontantHt { get; set; }

    public decimal TauxRemise { get; set; }

    public decimal MontantRemise { get; set; }

    public decimal MontantFodec { get; set; }

    public decimal NetHt { get; set; }

    public decimal TauxTva { get; set; }

    public decimal MontantTva { get; set; }

    public decimal MontantTtc { get; set; }

    public string Observation { get; set; } = null!;

    public string NumeroBonLivraisonVente { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public int NumeroOrdre { get; set; }

    public decimal PrixAchatNet { get; set; }
}
