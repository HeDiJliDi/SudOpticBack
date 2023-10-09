using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Article
{
    public string CodeArticle { get; set; } = null!;

    public string CodeFamille { get; set; } = null!;

    public string CodeSousFamille { get; set; } = null!;

    public string CodeType { get; set; } = null!;

    public string CodeMarque { get; set; } = null!;

    public string CodeUnite { get; set; } = null!;

    public string? CodeUniteVente { get; set; }

    public decimal ValeurUniteVente { get; set; }

    public string Designation { get; set; } = null!;

    public decimal DernierPrixAchatHt { get; set; }

    public decimal DernierTauxRemise { get; set; }

    public decimal PrixAchatHt { get; set; }

    public decimal Marge { get; set; }

    public decimal PrixVenteHt { get; set; }

    public string CodeTva { get; set; } = null!;

    public decimal PrixVenteTtc { get; set; }

    public decimal LiteTauxRemise { get; set; }

    public bool Fodec { get; set; }

    public bool Stockable { get; set; }

    public bool Actif { get; set; }

    public bool TailleCouleur { get; set; }

    public string Observation { get; set; } = null!;

    public bool NumeroSerie { get; set; }

    public string CodeBarre { get; set; } = null!;

    public byte[]? ImageCodeBarre { get; set; }

    public byte[]? Logo { get; set; }

    public string CodeFournisseur { get; set; } = null!;

    public string CodeSexe { get; set; } = null!;

    public decimal DernierPrixDevise { get; set; }

    public string Reference { get; set; } = null!;

    public string CodeCouleur { get; set; } = null!;

    public string CodeCalibre { get; set; } = null!;

    public string CodeEtui { get; set; } = null!;

    public bool Destockage { get; set; }

    public decimal DernierPrixAchatAvantCalculCout { get; set; }

    public DateTime DateCreation { get; set; }
}
