using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueAvanceFournisseur
{
    public string NumeroAvanceFournisseur { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public DateTime DateAvance { get; set; }

    public decimal MontantAvance { get; set; }

    public string CodeFournisseur { get; set; } = null!;

    public decimal MontantRetenu { get; set; }

    public decimal NetAvance { get; set; }

    public string EtatAvance { get; set; } = null!;

    public int Choix { get; set; }
}
