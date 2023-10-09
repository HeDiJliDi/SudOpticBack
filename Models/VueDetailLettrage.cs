using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueDetailLettrage
{
    public string NumeroPiece { get; set; } = null!;

    public string TypePiece { get; set; } = null!;

    public string NumeroReglementClient { get; set; } = null!;

    public decimal TotalPayee { get; set; }
}
