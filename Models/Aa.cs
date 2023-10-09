using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Aa
{
    public string CodeArticle { get; set; } = null!;

    public decimal PrixAchatHt { get; set; }

    public decimal PrixAchatTtc { get; set; }

    public decimal Marge { get; set; }

    public decimal PrixVenteHt { get; set; }

    public decimal PrixVenteTtc { get; set; }
}
