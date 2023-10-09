using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeBordereauVersementPourConsultation
{
    public DateTime DateReglement { get; set; }

    public string CodeClient { get; set; } = null!;

    public string NumeroReglementClient { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public DateTime Echeance { get; set; }

    public string CodeBanque { get; set; } = null!;

    public decimal MontantRecu { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string? CodeCompte { get; set; }

    public string MontantLettre { get; set; } = null!;

    public bool Imprimer { get; set; }

    public string Porteur { get; set; } = null!;

    public string Rib { get; set; } = null!;

    public bool Comptable { get; set; }

    public string NumeroBordereau { get; set; } = null!;

    public decimal MontantVerser { get; set; }

    public string NumeroOperationRecu { get; set; } = null!;

    public string NumeroCommution { get; set; } = null!;

    public decimal TauxCommution { get; set; }

    public decimal MontantCommution { get; set; }

    public decimal MontantRestant { get; set; }

    public bool Annuler { get; set; }

    public string? Banque { get; set; }
}
