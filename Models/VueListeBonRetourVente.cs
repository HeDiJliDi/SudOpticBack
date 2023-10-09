using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeBonRetourVente
{
    public string NumeroBonRetourVente { get; set; } = null!;

    public DateTime DateBonRetourVente { get; set; }

    public string RaisonSociale { get; set; } = null!;

    public string? Depot { get; set; }

    public string? NumeroBonLivraisonVente { get; set; }

    public string Expr1 { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public string CodeDepot { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalRemise { get; set; }

    public decimal TotalFodec { get; set; }

    public decimal TotalNetHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string Observation { get; set; } = null!;

    public string CodeLivreur { get; set; } = null!;

    public decimal TauxRemiseExceptionnel { get; set; }

    public decimal MontantRemiseExceptionnel { get; set; }

    public string NumeroAvoirVente { get; set; } = null!;

    public string? LibelleEtat { get; set; }

    public string? NomPrenom { get; set; }

    public string CodeTypeVente { get; set; } = null!;

    public DateTime DateCommande { get; set; }
}
