using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class DemandePrix
{
    public string NumeroDemandePrix { get; set; } = null!;

    public DateTime DateDemandePrix { get; set; }

    public string CodeFournisseur { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string Observation { get; set; } = null!;
}
