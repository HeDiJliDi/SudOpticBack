using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueLigneReglementClient
{
    public string NumeroReglementClient { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public DateTime DatePiece { get; set; }

    public decimal TotalPayee { get; set; }

    public decimal MontantPieceTtc { get; set; }

    public decimal TotalTva { get; set; }

    public decimal Totalretenu { get; set; }
}
