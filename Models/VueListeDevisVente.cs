using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeDevisVente
{
    public string NumeroDevisVente { get; set; } = null!;

    public DateTime DateDevisVente { get; set; }

    public string RaisonSociale { get; set; } = null!;

    public decimal TotalNetHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string Etat { get; set; } = null!;

    public string CodeClient { get; set; } = null!;
}
