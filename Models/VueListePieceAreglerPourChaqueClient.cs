using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListePieceAreglerPourChaqueClient
{
    public DateTime DatePiece { get; set; }

    public string CodeClient { get; set; } = null!;

    public decimal MontantPiece { get; set; }

    public string NumeroPiece { get; set; } = null!;
}
