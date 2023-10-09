using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class LettragePourCommussion
{
    public string NumeroReglementClient { get; set; } = null!;

    public DateTime DateReglement { get; set; }

    public string CodeClient { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public DateTime Echeance { get; set; }

    public string CodeBanque { get; set; } = null!;

    public decimal MontantRecu { get; set; }

    public string CodeTypeVente { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public DateTime DatePiece { get; set; }

    public decimal MontantPrincipal { get; set; }

    public decimal MontantPieceTtc { get; set; }
}
