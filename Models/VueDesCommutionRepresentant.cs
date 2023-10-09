using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueDesCommutionRepresentant
{
    public string NumeroCommution { get; set; } = null!;

    public DateTime DateCommution { get; set; }

    public DateTime DateDebut { get; set; }

    public DateTime DateFin { get; set; }

    public string CodeLivreur { get; set; } = null!;

    public string NomPrenom { get; set; } = null!;

    public string Observation { get; set; } = null!;
}
