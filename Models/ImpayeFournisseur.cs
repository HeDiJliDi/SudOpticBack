using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ImpayeFournisseur
{
    public string NumeroImpayeFournisseur { get; set; } = null!;

    public DateTime DateImpayeFournisseur { get; set; }

    public string CodeFournisseur { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }
}
