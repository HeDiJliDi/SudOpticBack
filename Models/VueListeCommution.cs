using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeCommution
{
    public string NumeroReglementClient { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public DateTime Echeance { get; set; }

    public decimal MontantRecu { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public string RaisonSociale { get; set; } = null!;

    public string CodeLivreur { get; set; } = null!;

    public string NomPrenom { get; set; } = null!;

    public DateTime DateReglement { get; set; }

    public decimal MontantCommution { get; set; }

    public decimal TauxCommution { get; set; }

    public string NumeroCommution { get; set; } = null!;
}
