using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Inventaire
{
    public string NumeroInventaire { get; set; } = null!;

    public DateTime? DateInventaire { get; set; }

    public string CodeDepot { get; set; } = null!;

    public string NomCreateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string NomValidateur { get; set; } = null!;

    public DateTime? DateValidation { get; set; }

    public DateTime? HeureValidation { get; set; }

    public string Observation { get; set; } = null!;
}
