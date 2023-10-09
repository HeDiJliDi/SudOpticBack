using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class SaisieFicheClient
{
    public string NumeroSaisie { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string Libelle { get; set; } = null!;

    public DateTime DateOperation { get; set; }

    public decimal Montant { get; set; }

    public string TypeOperation { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string CodeCompte { get; set; } = null!;

    public decimal MontantReel { get; set; }

    public decimal MontantNoir { get; set; }
}
