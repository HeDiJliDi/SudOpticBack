using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeAvanceFournisseur
{
    public string NumeroAvanceFournisseur { get; set; } = null!;

    public string Fournisseur { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public DateTime DateAvance { get; set; }

    public decimal MontantAvance { get; set; }

    public string EtatAvance { get; set; } = null!;

    public string CodeFournisseur { get; set; } = null!;
}
