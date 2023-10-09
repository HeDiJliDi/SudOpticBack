using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueRapportValise
{
    public string NumerPiece { get; set; } = null!;

    public DateTime DatePiece { get; set; }

    public string Designation { get; set; } = null!;

    public string Libelle { get; set; } = null!;

    public string CodeDepot { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public decimal Quantite { get; set; }

    public decimal Entrer { get; set; }

    public decimal Sortie { get; set; }
}
