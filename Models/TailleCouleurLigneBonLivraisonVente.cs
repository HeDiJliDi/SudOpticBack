using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class TailleCouleurLigneBonLivraisonVente
{
    public string NumeroBonLivraisonVente { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string CodeCouleur { get; set; } = null!;

    public string Taille { get; set; } = null!;

    public decimal Quantite { get; set; }
}
