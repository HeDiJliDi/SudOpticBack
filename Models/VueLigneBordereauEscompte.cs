using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueLigneBordereauEscompte
{
    public string NumeroBordereau { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public DateTime Echeance { get; set; }

    public decimal Montant { get; set; }

    public string NumeroFactureVente { get; set; } = null!;

    public string NumeroReglementClient { get; set; } = null!;

    public int Ordre { get; set; }

    public string Reference { get; set; } = null!;

    public decimal TotalTtc { get; set; }

    public DateTime DateFactureVente { get; set; }

    public string RaisonSociale { get; set; } = null!;
}
