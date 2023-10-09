using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeBonLivraisonAchat
{
    public decimal FraisTransport { get; set; }

    public bool Bldevise { get; set; }

    public string NumeroBonLivraisonAchat { get; set; } = null!;

    public DateTime DateBonLivraisonAchat { get; set; }

    public string CodeFournisseur { get; set; } = null!;

    public string RaisonSociale { get; set; } = null!;

    public decimal TotalTtc { get; set; }

    public string Depot { get; set; } = null!;

    public string NumeroEtat { get; set; } = null!;

    public string Etat { get; set; } = null!;

    public int Ajouter { get; set; }

    public string ReferenceFournisseur { get; set; } = null!;
}
