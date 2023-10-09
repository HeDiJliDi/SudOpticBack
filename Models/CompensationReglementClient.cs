using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class CompensationReglementClient
{
    public string NumeroReglementClient { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public decimal MontantPieceTtc { get; set; }
}
