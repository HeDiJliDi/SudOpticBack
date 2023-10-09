using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class RetourReglement
{
    public string NumeroRetourReglement { get; set; } = null!;

    public DateTime DateRetourReglement { get; set; }

    public string CodeClient { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public decimal MontantRetourReglement { get; set; }

    public int NumeroOrdre { get; set; }

    public string CodeCompte { get; set; } = null!;
}
