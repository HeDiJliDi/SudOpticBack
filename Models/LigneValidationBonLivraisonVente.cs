using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class LigneValidationBonLivraisonVente
{
    public string NumeroBonLivraisonVente { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string DesignationArticle { get; set; } = null!;

    public int NumeroOrdre { get; set; }

    public decimal Quantite { get; set; }
}
