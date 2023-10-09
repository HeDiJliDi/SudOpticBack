using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeArticle
{
    public string? LibelleFamille { get; set; }

    public string CodeArticle { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public string? LibelleMarque { get; set; }

    public decimal PrixAchatHt { get; set; }

    public decimal PrixVenteHt { get; set; }

    public decimal PrixVenteTtc { get; set; }

    public decimal LiteTauxRemise { get; set; }

    public bool Stockable { get; set; }

    public string CodeFamille { get; set; } = null!;

    public string CodeSousFamille { get; set; } = null!;

    public string CodeType { get; set; } = null!;

    public string? Libelletype { get; set; }

    public string CodeMarque { get; set; } = null!;

    public string CodeUnite { get; set; } = null!;

    public decimal Marge { get; set; }

    public string CodeTva { get; set; } = null!;

    public decimal? TauxTva { get; set; }

    public bool Fodec { get; set; }

    public bool Actif { get; set; }

    public bool TailleCouleur { get; set; }

    public string Observation { get; set; } = null!;

    public decimal DernierPrixAchatHt { get; set; }

    public decimal DernierTauxRemise { get; set; }

    public string? CodeUniteVente { get; set; }

    public decimal ValeurUniteVente { get; set; }

    public int? Quantite { get; set; }

    public string CodeBarre { get; set; } = null!;

    public string CodeFournisseur { get; set; } = null!;

    public string CodeSexe { get; set; } = null!;

    public decimal DernierPrixDevise { get; set; }

    public string Reference { get; set; } = null!;

    public string CodeCouleur { get; set; } = null!;

    public string CodeCalibre { get; set; } = null!;

    public string CodeEtui { get; set; } = null!;

    public bool Destockage { get; set; }
}
