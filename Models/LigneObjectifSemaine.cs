using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class LigneObjectifSemaine
{
    public string NumeroObjectifSemaine { get; set; } = null!;

    public string CodeMarque { get; set; } = null!;

    public string DesignationMarque { get; set; } = null!;

    public int NumeroOrdre { get; set; }

    public decimal Quantite { get; set; }

    public string Observation { get; set; } = null!;
}
