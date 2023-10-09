using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class RetenuSource
{
    public string CodeRetenu { get; set; } = null!;

    public string Libelle { get; set; } = null!;

    public decimal TauxRetenu { get; set; }

    public string TypeRetenu { get; set; } = null!;
}
