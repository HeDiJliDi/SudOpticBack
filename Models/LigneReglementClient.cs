using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class LigneReglementClient
{
    public string NumeroReglementClient { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public decimal TotalTva { get; set; }

    public decimal MontantPieceTtc { get; set; }

    public string Observation { get; set; } = null!;

    public decimal TotalRecu { get; set; }

    public decimal TotalRestant { get; set; }

    public decimal TotalPayee { get; set; }

    public DateTime PieceDate { get; set; }

    public string TypePiece { get; set; } = null!;
}
