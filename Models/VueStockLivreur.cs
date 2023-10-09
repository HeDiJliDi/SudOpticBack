using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueStockLivreur
{
    public string CodeLivreur { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public decimal? Quantite { get; set; }

    public string CodeFamille { get; set; } = null!;

    public string CodeType { get; set; } = null!;

    public string CodeMarque { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public decimal PrixVenteHt { get; set; }

    public string CodeTva { get; set; } = null!;

    public decimal PrixVenteTtc { get; set; }

    public string CodeBarre { get; set; } = null!;

    public string CodeFournisseur { get; set; } = null!;

    public string NomPrenom { get; set; } = null!;

    public string MarqueArticle { get; set; } = null!;
}
