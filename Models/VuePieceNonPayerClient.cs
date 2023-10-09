using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VuePieceNonPayerClient
{
    public string? NumeroPiece { get; set; }

    public string? CodeClient { get; set; }

    public decimal? TotalPiece { get; set; }

    public decimal? TotalPayee { get; set; }

    public decimal? Restant { get; set; }
}
