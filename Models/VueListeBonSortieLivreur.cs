using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeBonSortieLivreur
{
    public string NumeroBonSortieLivreur { get; set; } = null!;

    public DateTime DateBonSortieLivreur { get; set; }

    public string CodeLivreur { get; set; } = null!;

    public string DepotSource { get; set; } = null!;

    public string CodeCamion { get; set; } = null!;

    public string CodeDepotDestignation { get; set; } = null!;

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

    public string? NomPrenom { get; set; }

    public string? LibelleCamion { get; set; }

    public string LibelleEtat { get; set; } = null!;

    public string CodeMarque { get; set; } = null!;

    public string CodeFamille { get; set; } = null!;
}
