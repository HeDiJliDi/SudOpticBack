using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeAvanceClient
{
    public string NumeroAvanceClient { get; set; } = null!;

    public string Client { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public DateTime DateAvance { get; set; }

    public decimal MontantAvance { get; set; }

    public string EtatAvance { get; set; } = null!;

    public string CodeClient { get; set; } = null!;
}
