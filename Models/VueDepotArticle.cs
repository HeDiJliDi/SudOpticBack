using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueDepotArticle
{
    public string CodeDepot { get; set; } = null!;

    public string Depot { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string? Designation { get; set; }

    public decimal Quantite { get; set; }

    public decimal PrixUnitaireAchat { get; set; }

    public decimal? PrixVenteHt { get; set; }

    public decimal? PrixVenteTtc { get; set; }

    public decimal? LiteTauxRemise { get; set; }

    public string? CodeFamille { get; set; }

    public string? CodeMarque { get; set; }

    public string? CodeFournisseur { get; set; }

    public string? RaisonSociale { get; set; }

    public string? FamilleArticle { get; set; }

    public string? MarqueArticle { get; set; }
}
