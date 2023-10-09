using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ValidationDecaissement
{
    public string NumeroValidation { get; set; } = null!;

    public DateTime DateValidation { get; set; }

    public decimal MontantGlobal { get; set; }

    public string CodeBanque { get; set; } = null!;

    public DateTime DateCreation { get; set; }

    public DateTime HeureCreation { get; set; }

    public string NomUtilisateur { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public DateTime DateDebutEcheance { get; set; }

    public DateTime DateFinEcheance { get; set; }

    public string CodeCompte { get; set; } = null!;
}
