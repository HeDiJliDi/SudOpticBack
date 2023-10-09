using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeFactureAchat
{
    public string NumeroFactureAchat { get; set; } = null!;

    public DateTime DateFactureAchat { get; set; }

    public string Fournisseur { get; set; } = null!;

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string Etat { get; set; } = null!;

    public string ReferenceFournisseur { get; set; } = null!;

    public string CodeFournisseur { get; set; } = null!;

    public decimal TotalNetHt { get; set; }

    public bool Export { get; set; }
}
