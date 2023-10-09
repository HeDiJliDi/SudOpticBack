using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueEtatArticleVendu
{
    public string CodeArticle { get; set; } = null!;

    public string CodeFamille { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public string CodeMarque { get; set; } = null!;

    public string LibelleMarque { get; set; } = null!;

    public decimal Quantite { get; set; }

    public DateTime DateBonLivraisonVente { get; set; }

    public string NumeroBonLivraisonVente { get; set; } = null!;

    public decimal NetHt { get; set; }
}
