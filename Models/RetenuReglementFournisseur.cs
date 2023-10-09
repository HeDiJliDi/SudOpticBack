using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class RetenuReglementFournisseur
{
    public string NumeroReglementFournisseur { get; set; } = null!;

    public string CodeRetenu { get; set; } = null!;

    public decimal TauxRetenu { get; set; }

    public decimal MontantRetenu { get; set; }
}
