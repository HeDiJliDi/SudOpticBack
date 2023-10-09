﻿using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class TvabonEntrer
{
    public string NumeroBonEntrer { get; set; } = null!;

    public string CodeTva { get; set; } = null!;

    public decimal TauxTva { get; set; }

    public decimal BaseHt { get; set; }

    public decimal MontantTva { get; set; }
}
