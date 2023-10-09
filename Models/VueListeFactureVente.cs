using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeFactureVente
{
    public string NumeroFactureVente { get; set; } = null!;

    public DateTime DateFactureVente { get; set; }

    public string Client { get; set; } = null!;

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string Etat { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public decimal TotalNetHt { get; set; }
}
