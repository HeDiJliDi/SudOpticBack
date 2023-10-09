using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueDetailEntrerSortieArticle
{
    public DateTime DatePiece { get; set; }

    public string CodeFamille { get; set; } = null!;

    public string CodeMarque { get; set; } = null!;

    public string Tier { get; set; } = null!;

    public string Operation { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public string CodeDepot { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public decimal Entree { get; set; }

    public decimal Sortie { get; set; }

    public decimal PrixUnitaire { get; set; }

    public DateTime? HeureCreaion { get; set; }
}
