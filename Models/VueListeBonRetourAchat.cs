using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeBonRetourAchat
{
    public string NumeroBonRetourAchat { get; set; } = null!;

    public DateTime DateBonRetourAchat { get; set; }

    public string RaisonSociale { get; set; } = null!;

    public decimal TotalTtc { get; set; }

    public string Depot { get; set; } = null!;

    public string? NumeroBonLivraisonAchat { get; set; }
}
