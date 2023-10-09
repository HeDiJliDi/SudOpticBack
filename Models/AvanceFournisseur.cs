using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class AvanceFournisseur
{
    public string NumeroAvanceFournisseur { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public string NumeroReglementFournisseur { get; set; } = null!;

    public DateTime DateAvance { get; set; }

    public string CodeFournisseur { get; set; } = null!;

    public decimal MontantAvance { get; set; }

    public string CodeRetenu { get; set; } = null!;

    public decimal TauxRetenu { get; set; }

    public decimal MontantRetenu { get; set; }

    public decimal NetAvance { get; set; }

    public string CodeModeReglement { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public DateTime Echeance { get; set; }

    public string EtatAvance { get; set; } = null!;

    public string CodeBanque { get; set; } = null!;

    public string CodeCompte { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string Observation { get; set; } = null!;
}
