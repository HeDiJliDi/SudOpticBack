using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ImpayeClient
{
    public string NumeroImpayeClient { get; set; } = null!;

    public DateTime DateImpayeClient { get; set; }

    public string CodeClient { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public decimal MontantImpayeClient { get; set; }

    public decimal TotaleRecu { get; set; }

    public decimal MontantRecu { get; set; }
}
