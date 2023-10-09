using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class SuivieRepresantant
{
    public int NumeroSuivieRepresentant { get; set; }

    public string CodeLivreur { get; set; } = null!;

    public DateTime DateDebut { get; set; }

    public DateTime DateFin { get; set; }

    public string TypeSuivie { get; set; } = null!;
}
