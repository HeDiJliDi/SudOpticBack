using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueRechercheArticleQuantite
{
    public string CodeArticle { get; set; } = null!;

    public bool Stockable { get; set; }

    public decimal Quantite { get; set; }

    public string CodeDepot { get; set; } = null!;

    public string? FamilleArticle { get; set; }

    public string CodeFamille { get; set; } = null!;

    public string CodeType { get; set; } = null!;

    public string? TypeArticle { get; set; }

    public string CodeMarque { get; set; } = null!;

    public string? MarqueArticle { get; set; }

    public string CodeUnite { get; set; } = null!;

    public string? UniteArticle { get; set; }

    public string Designation { get; set; } = null!;

    public decimal DernierPrixAchatHt { get; set; }

    public decimal DernierTauxRemise { get; set; }

    public decimal PrixAchatHt { get; set; }

    public decimal Marge { get; set; }

    public decimal PrixVenteHt { get; set; }

    public decimal? TauxTva { get; set; }

    public decimal PrixVenteTtc { get; set; }

    public bool Actif { get; set; }

    public string CodeBarre { get; set; } = null!;

    public string CodeFournisseur { get; set; } = null!;

    public string CodeSexe { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public decimal DernierPrixDevise { get; set; }

    public string CodeCouleur { get; set; } = null!;

    public string CodeCalibre { get; set; } = null!;

    public string CodeEtui { get; set; } = null!;
}
