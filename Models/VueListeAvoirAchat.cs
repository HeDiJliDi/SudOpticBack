using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeAvoirAchat
{
    public string NumeroAvoirAchat { get; set; } = null!;

    public DateTime DateAvoirAchat { get; set; }

    public string NumeroFactureAchat { get; set; } = null!;

    public string RaisonSociale { get; set; } = null!;

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string CodeFournisseur { get; set; } = null!;

    public string ReferenceFournisseur { get; set; } = null!;

    public decimal TotalNetHt { get; set; }
}
