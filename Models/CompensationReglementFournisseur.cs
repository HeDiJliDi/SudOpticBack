using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class CompensationReglementFournisseur
{
    public string NumeroReglementFournisseur { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public decimal MontantPieceTtc { get; set; }
}
