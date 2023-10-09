using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeBonLivraisonVente
{
    public decimal TotalRecu { get; set; }

    public decimal? TotalRestant { get; set; }

    public string ObservationInterne { get; set; } = null!;

    public decimal TotalRemise { get; set; }

    public DateTime DateLivraison { get; set; }

    public string NumeroBonLivraisonVente { get; set; } = null!;

    public DateTime DateBonLivraisonVente { get; set; }

    public string RaisonSociale { get; set; } = null!;

    public decimal TotalTtc { get; set; }

    public string Libelle { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public string? CodeDepot { get; set; }

    public string CodeLivreur { get; set; } = null!;

    public decimal TauxRemiseExceptionnel { get; set; }

    public decimal MontantRemiseExceptionnel { get; set; }

    public string CodeTypeVente { get; set; } = null!;

    public DateTime DateCommande { get; set; }

    public string NomValideur { get; set; } = null!;

    public DateTime DateValidation { get; set; }

    public bool Valider { get; set; }

    public string NumeroFactureVente { get; set; } = null!;

    public string NumeroBonCommandeVente { get; set; } = null!;

    public decimal TotalTva { get; set; }

    public decimal TotalNetHt { get; set; }

    public decimal TotalHt { get; set; }
}
