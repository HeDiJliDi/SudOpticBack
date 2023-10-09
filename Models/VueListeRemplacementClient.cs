using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeRemplacementClient
{
    public string NumeroReglementClient { get; set; } = null!;

    public DateTime DateReglement { get; set; }

    public string Client { get; set; } = null!;

    public decimal TotalBrute { get; set; }

    public decimal TotalRetenu { get; set; }

    public decimal TotalNet { get; set; }

    public string CodeClient { get; set; } = null!;
}
