using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeReglementParLivreur
{
    public string NomPrenom { get; set; } = null!;

    public string CodeLivreur { get; set; } = null!;

    public DateTime DateReglement { get; set; }

    public string NumeroReglementClient { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public decimal MontantRecu { get; set; }

    public string CodeClient { get; set; } = null!;

    public string RaisonSociale { get; set; } = null!;
}
