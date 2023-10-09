using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Compte
{
    public string CodeCompte { get; set; } = null!;

    public string Libelle { get; set; } = null!;

    public string NomBordereau { get; set; } = null!;

    public string Ribbancaire { get; set; } = null!;
}
