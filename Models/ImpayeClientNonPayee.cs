using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ImpayeClientNonPayee
{
    public string CodeLivreur { get; set; } = null!;

    public decimal? Restant { get; set; }

    public string NomClient { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public string CodeBanque { get; set; } = null!;

    public string? CodeCompte { get; set; }

    public DateTime Echeance { get; set; }

    public decimal MontantRecu { get; set; }

    public string NumeroReglementClient { get; set; } = null!;

    public string Porteur { get; set; } = null!;
}
