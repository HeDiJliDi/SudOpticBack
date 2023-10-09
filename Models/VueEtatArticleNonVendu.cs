using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueEtatArticleNonVendu
{
    public string CodeArticle { get; set; } = null!;

    public string CodeFamille { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public decimal? Quantite { get; set; }

    public string CodeDepot { get; set; } = null!;

    public DateTime? DateBonLivraisonVente { get; set; }

    public string? NumeroBonLivraisonVente { get; set; }
}
