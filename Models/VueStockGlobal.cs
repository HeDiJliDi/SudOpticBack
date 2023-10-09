using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueStockGlobal
{
    public string CodeArticle { get; set; } = null!;

    public string CodeFamille { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public decimal? DepotCentral { get; set; }

    public decimal Firas { get; set; }

    public decimal Amine { get; set; }

    public decimal Wassim { get; set; }

    public decimal Stockglobal { get; set; }
}
