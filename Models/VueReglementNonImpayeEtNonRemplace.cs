using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueReglementNonImpayeEtNonRemplace
{
    public string? LibelleCompte { get; set; }

    public decimal MontantRecu { get; set; }

    public DateTime Echeance { get; set; }

    public DateTime DateReglement { get; set; }

    public string CodeClient { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public string? CodeCompte { get; set; }

    public string CodeBanque { get; set; } = null!;

    public string NumeroReglementClient { get; set; } = null!;
}
