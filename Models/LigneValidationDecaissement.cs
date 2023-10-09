using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class LigneValidationDecaissement
{
    public string NumeroValidation { get; set; } = null!;

    public string NumeroReglementFournisseur { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public DateTime Echeance { get; set; }

    public decimal Montant { get; set; }

    public int Ordre { get; set; }

    public DateTime DateValidationPiece { get; set; }
}
