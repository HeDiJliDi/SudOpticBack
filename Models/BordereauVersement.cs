using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class BordereauVersement
{
    public string NumeroBordereau { get; set; } = null!;

    public string NumeroBancaire { get; set; } = null!;

    public DateTime DateBordereau { get; set; }

    public decimal MontantBordereau { get; set; }

    public string CodeBanque { get; set; } = null!;

    public DateTime DateCreation { get; set; }

    public DateTime HeureCreation { get; set; }

    public string NomUtilisateur { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public DateTime DateDebutEcheance { get; set; }

    public DateTime DateFinEcheance { get; set; }

    public string CodeCompte { get; set; } = null!;

    public string DateValidation { get; set; } = null!;
}
