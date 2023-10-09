using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeBonRetourLivreur
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

    public string LibelleDepot { get; set; } = null!;

    public string LibelleCamion { get; set; } = null!;

    public string NomPrenom { get; set; } = null!;

    public string LibelleEtat { get; set; } = null!;
}
