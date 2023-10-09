using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueOperationProgramme
{
    public DateTime? HeureCreation { get; set; }

    public DateTime? DateOperation { get; set; }

    public string Nature { get; set; } = null!;

    public string NumeroBonCommandeVente { get; set; } = null!;

    public string Opération { get; set; } = null!;

    public string? Utilisateur { get; set; }
}
