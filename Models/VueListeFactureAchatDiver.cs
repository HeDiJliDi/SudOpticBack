using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeFactureAchatDiver
{
    public string NumeroAchatDiver { get; set; } = null!;

    public string CodeFournisseur { get; set; } = null!;

    public string Fournisseur { get; set; } = null!;

    public string ReferenceFournisseur { get; set; } = null!;

    public DateTime DateAchatDiver { get; set; }

    public decimal TotalNetHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string Etat { get; set; } = null!;
}
