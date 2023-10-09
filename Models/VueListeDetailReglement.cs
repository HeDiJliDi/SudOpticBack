using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeDetailReglement
{
    public string NumeroReglementClient { get; set; } = null!;

    public string CodeLivreur { get; set; } = null!;

    public DateTime DateReglement { get; set; }

    public string CodeClient { get; set; } = null!;

    public string RaisonSociale { get; set; } = null!;

    public string Libelle { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public DateTime Echeance { get; set; }

    public decimal MontantRecu { get; set; }

    public string? NumeroPiece { get; set; }

    public string NomPrenom { get; set; } = null!;
}
