using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Tva
{
    public string CodeTva { get; set; } = null!;

    public decimal TauxTva { get; set; }
}
