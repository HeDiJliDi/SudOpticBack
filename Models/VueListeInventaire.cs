using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeInventaire
{
    public string NumeroInventaire { get; set; } = null!;

    public DateTime? DateInventaire { get; set; }

    public string Depot { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? DateValidation { get; set; }

    public string Observation { get; set; } = null!;
}
