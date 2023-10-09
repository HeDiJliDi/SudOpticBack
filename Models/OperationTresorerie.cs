using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class OperationTresorerie
{
    public string NumeroOperation { get; set; } = null!;

    public DateTime DateOperation { get; set; }

    public string Libelle { get; set; } = null!;

    public decimal Montant { get; set; }

    public string NomUtilisateur { get; set; } = null!;

    public DateTime DateCreation { get; set; }

    public DateTime HeureCreation { get; set; }

    public string TypeOperation { get; set; } = null!;

    public string CodeBanque { get; set; } = null!;

    public string NumeroBordereau { get; set; } = null!;
}
