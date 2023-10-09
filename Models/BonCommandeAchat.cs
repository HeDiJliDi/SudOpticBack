using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class BonCommandeAchat
{
    public string NumeroBonCommandeAchat { get; set; } = null!;

    public DateTime DateBonCommandeAchat { get; set; }

    public string CodeFournisseur { get; set; } = null!;

    public string DelaiLivraison { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string Observation { get; set; } = null!;

    public string Nref { get; set; } = null!;

    public string Vref { get; set; } = null!;

    public string VilleLivraison { get; set; } = null!;

    public string ModalitePaiement { get; set; } = null!;

    public decimal TotalRemise { get; set; }

    public decimal TotalFodec { get; set; }

    public decimal TotalNetHt { get; set; }
}
