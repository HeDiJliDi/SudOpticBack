using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ImpressionCreditSociete
{
    public string CodeClient { get; set; } = null!;

    public DateTime DatePiece { get; set; }

    public string NumeroPiece { get; set; } = null!;

    public decimal MontantTtc { get; set; }

    public decimal TotalPayee { get; set; }

    public decimal Restant { get; set; }

    public DateTime HeureCreation { get; set; }
}
