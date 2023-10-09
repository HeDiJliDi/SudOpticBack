using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VuePieceValiserRecuperer
{
    public string NumeroBonCommandeVente { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string DesignationArticle { get; set; } = null!;

    public decimal Quantite { get; set; }

    public decimal? StockAgence { get; set; }

    public string Traitement { get; set; } = null!;

    public decimal StockValise { get; set; }
}
