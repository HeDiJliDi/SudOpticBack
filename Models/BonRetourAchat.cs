using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class BonRetourAchat
{
    public string NumeroBonRetourAchat { get; set; } = null!;

    public DateTime DateBonRetourAchat { get; set; }

    public string NumeroBonLivraisonAchat { get; set; } = null!;

    public string CodeFournisseur { get; set; } = null!;

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
}
