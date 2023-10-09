using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class LigneCommutionRepresentant
{
    public string NumeroCommution { get; set; } = null!;

    public string CodeLivreur { get; set; } = null!;

    public string NumeroReglementClient { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public decimal MontantRecu { get; set; }

    public decimal TauxCommution { get; set; }

    public decimal MontantCommution { get; set; }

    public int Id { get; set; }
}
