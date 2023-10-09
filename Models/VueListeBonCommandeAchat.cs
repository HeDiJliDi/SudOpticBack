using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeBonCommandeAchat
{
    public string NumeroBonCommandeAchat { get; set; } = null!;

    public DateTime DateBonCommandeAchat { get; set; }

    public string Fournisseur { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string Etat { get; set; } = null!;

    public string CodeFournisseur { get; set; } = null!;
}
