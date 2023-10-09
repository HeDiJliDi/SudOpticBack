using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueDepence
{
    public string NumeroDepence { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public string Proteur { get; set; } = null!;

    public string Observation { get; set; } = null!;

    public string TypeDepence { get; set; } = null!;

    public decimal MontantRecu { get; set; }

    public DateTime DateDepence { get; set; }

    public string LibelleDepense { get; set; } = null!;

    public int NumeroLigne { get; set; }

    public string NumeroBonCommandeAchat { get; set; } = null!;
}
