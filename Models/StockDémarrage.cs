using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class StockDémarrage
{
    public string CodeArticle { get; set; } = null!;

    public decimal Qte { get; set; }
}
