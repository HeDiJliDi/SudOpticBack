using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeBonCommandeVente
{
    public string NumeroBonCommandeVente { get; set; } = null!;

    public DateTime DateBonCommandeVente { get; set; }

    public string RaisonSociale { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string Libelle { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public decimal TotalRemise { get; set; }

    public decimal TotalFodec { get; set; }

    public decimal TotalNetHt { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string ReferenceClient { get; set; } = null!;
}
