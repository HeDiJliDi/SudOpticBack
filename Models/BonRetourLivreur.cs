using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class BonRetourLivreur
{
    public string NumeroBonRetourLivreur { get; set; } = null!;

    public DateTime DateBonRetourLivreur { get; set; }

    public string NumeroBonSortieLivreur { get; set; } = null!;

    public string CodeLivreur { get; set; } = null!;

    public string CodeDepotRetour { get; set; } = null!;

    public string CodeDepotLivreur { get; set; } = null!;

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

    public decimal CreditClient { get; set; }

    public decimal CreditLivreur { get; set; }

    public decimal DepenceLivreur { get; set; }

    public decimal DepenceFixe { get; set; }

    public decimal RecouvementClient { get; set; }

    public decimal RecouvrementLivreur { get; set; }

    public decimal ReboucementLivreur { get; set; }

    public decimal GolbalVente { get; set; }

    public decimal RecetteReel { get; set; }
}
