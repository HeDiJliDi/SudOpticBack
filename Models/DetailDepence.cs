using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class DetailDepence
{
    public string NumeroDepence { get; set; } = null!;

    public int NumeroLigne { get; set; }

    public string CodeModeReglement { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public DateTime Echeance { get; set; }

    public DateTime DateVersement { get; set; }

    public string CodeBanque { get; set; } = null!;

    public decimal MontantRecu { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string CodeCompte { get; set; } = null!;

    public string Observation { get; set; } = null!;

    public string Proteur { get; set; } = null!;

    public string CodeTypeDepense { get; set; } = null!;
}
