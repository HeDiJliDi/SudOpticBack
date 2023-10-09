using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueSuivieClient
{
    public string NumBordereauEscompte { get; set; } = null!;

    public string NumeroBordereau { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public decimal? Restant { get; set; }

    public DateTime DatePiece { get; set; }

    public string CodeClient { get; set; } = null!;

    public string Client { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public string ModeReglement { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public DateTime Echeance { get; set; }

    public string CodeBanque { get; set; } = null!;

    public string Banque { get; set; } = null!;

    public decimal MontantRecu { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string Etat { get; set; } = null!;

    public string? CodeCompte { get; set; }

    public string Compte { get; set; } = null!;

    public bool Annuler { get; set; }

    public string Porteur { get; set; } = null!;
}
