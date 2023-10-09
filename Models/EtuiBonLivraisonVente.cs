using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class EtuiBonLivraisonVente
{
    public string NumeroBonLivraisonVente { get; set; } = null!;

    public string CodeEtui { get; set; } = null!;

    public string DesignationArticle { get; set; } = null!;

    public decimal Quantite { get; set; }
}
