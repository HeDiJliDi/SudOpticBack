using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ReglementTemporaire
{
    public string NumeroReglementClient { get; set; } = null!;

    public DateTime DateReglement { get; set; }

    public string CodeModeReglement { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public string CodeLivreur { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public DateTime Echeance { get; set; }

    public string CodeBanque { get; set; } = null!;

    public decimal MontantRecu { get; set; }

    public string Porteur { get; set; } = null!;

    public string Rib { get; set; } = null!;
}
