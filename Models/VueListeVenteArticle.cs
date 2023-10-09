using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeVenteArticle
{
    public string? CodeZoneClient { get; set; }

    public string NumeroPiece { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public decimal PrixUvente { get; set; }

    public decimal? Quantite { get; set; }

    public decimal MontantHt { get; set; }

    public decimal TauxRemise { get; set; }

    public decimal MontantRemise { get; set; }

    public decimal NetHt { get; set; }

    public decimal TauxTva { get; set; }

    public decimal MontantTva { get; set; }

    public decimal MontantTtc { get; set; }

    public DateTime DatePiece { get; set; }

    public string CodeClient { get; set; } = null!;

    public string CodeDepot { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalRemise { get; set; }

    public decimal TotalNetHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string CodeLivreur { get; set; } = null!;

    public string? NomRepresentant { get; set; }

    public string? Zone { get; set; }

    public string? CodeFamille { get; set; }

    public string? CodeType { get; set; }

    public string? CodeMarque { get; set; }

    public string? CodeUniteVente { get; set; }

    public string? Designation { get; set; }

    public decimal? PrixAchatHt { get; set; }

    public bool? Stockable { get; set; }

    public bool? Actif { get; set; }

    public string? CodeBarre { get; set; }

    public string? CodeFournisseur { get; set; }

    public string? CodeSexe { get; set; }

    public string? Reference { get; set; }

    public string? CodeCouleur { get; set; }

    public string? CodeCalibre { get; set; }

    public string? CodeEtui { get; set; }

    public string? LibelleMarque { get; set; }

    public string? LibelleFamilleArticle { get; set; }

    public string? RaisonSocialeFournisseur { get; set; }

    public string? RaisonSocialeClient { get; set; }

    public string? CodeFamilleClient { get; set; }

    public string? LibelleFamilleClient { get; set; }

    public decimal TauxRemiseExceptionnel { get; set; }

    public string CodeTypeVente { get; set; } = null!;

    public string? RaisonSociale { get; set; }
}
