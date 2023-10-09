using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueArticle
{
    public string CodeArticle { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public string CodeTva { get; set; } = null!;

    public decimal PrixVenteTtc { get; set; }

    public decimal PrixVenteHt { get; set; }

    public decimal PrixAchatHt { get; set; }

    public decimal Quantite { get; set; }

    public decimal? QteRestante { get; set; }
}
