using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeDemandePrix
{
    public string NumeroDemandePrix { get; set; } = null!;

    public DateTime DateDemandePrix { get; set; }

    public string Fournisseur { get; set; } = null!;
}
