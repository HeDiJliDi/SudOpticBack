using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class CommutionRepresentant
{
    public string NumeroCommution { get; set; } = null!;

    public DateTime DateCommution { get; set; }

    public DateTime DateDebut { get; set; }

    public DateTime DateFin { get; set; }

    public string CodeLivreur { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string Observation { get; set; } = null!;
}
