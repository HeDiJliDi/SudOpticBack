using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueFactureBonLivraison
{
    public string NumeroFactureVente { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string NumeroEtat { get; set; } = null!;
}
