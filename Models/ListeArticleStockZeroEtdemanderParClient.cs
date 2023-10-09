using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ListeArticleStockZeroEtdemanderParClient
{
    public string NumeroBonCommandeVente { get; set; } = null!;

    public string Observation { get; set; } = null!;

    public decimal? MontantHt { get; set; }

    public decimal? MontantTva { get; set; }

    public decimal? MontantTtc { get; set; }

    public decimal TauxTva { get; set; }

    public string Designation { get; set; } = null!;

    public decimal PrixAchatHt { get; set; }

    public string CodeTva { get; set; } = null!;

    public string Libelle { get; set; } = null!;

    public decimal? QteRestante { get; set; }

    public string? CodeDepot { get; set; }

    public string? CodeArticle { get; set; }

    public decimal? Quantite { get; set; }
}
