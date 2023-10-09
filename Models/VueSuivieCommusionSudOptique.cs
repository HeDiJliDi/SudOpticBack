using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueSuivieCommusionSudOptique
{
    public int? NbJours { get; set; }

    public string? CodeLivreur { get; set; }

    public string NomPrenom { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public string RaisonSociale { get; set; } = null!;

    public string TypeVente { get; set; } = null!;

    public string NumeroReglementClient { get; set; } = null!;

    public DateTime DateReglement { get; set; }

    public string NumeroPiece { get; set; } = null!;

    public DateTime DatePiece { get; set; }

    public string CodeModeReglement { get; set; } = null!;

    public decimal MontantPrincipal { get; set; }

    public string Reference { get; set; } = null!;

    public DateTime Echeance { get; set; }

    public decimal MontantRecu { get; set; }

    public decimal TauxCommution { get; set; }

    public decimal MontantCommution { get; set; }

    public decimal MontantPieceTtc { get; set; }
}
