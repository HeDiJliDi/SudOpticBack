using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class SoldeClient
{
    public string CodeClient { get; set; } = null!;

    public decimal SoldeBl { get; set; }

    public decimal SoldeFv { get; set; }
}
