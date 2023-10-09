using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueDetailReglementClientFacturer
{
    public string NumeroReglementClient { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public DateTime Echeance { get; set; }

    public string CodeBanque { get; set; } = null!;

    public decimal MontantRecu { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string? CodeCompte { get; set; }

    public string NumeroBordereau { get; set; } = null!;

    public decimal MontantVerser { get; set; }

    public string NumeroFactureVente { get; set; } = null!;
}
