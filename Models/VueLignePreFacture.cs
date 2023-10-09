using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueLignePreFacture
{
    public string NumeroPreFacture { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string DesignationArticle { get; set; } = null!;

    public int NumeroOrdre { get; set; }

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

    public decimal PrixAchatNet { get; set; }

    public decimal MontantAvanceImpot { get; set; }

    public decimal? QuantiteCarton { get; set; }

    public decimal? PoidsBrut { get; set; }

    public decimal? PoidsNet { get; set; }

    public string? Libelle { get; set; }

    public string? CodeCouleur { get; set; }

    public string? DesignationParent { get; set; }

    public string? Pointure { get; set; }
}
