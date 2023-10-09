using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueMouvementStock
{
    public DateTime? HeureCreation { get; set; }

    public DateTime? DateCreation { get; set; }

    public string Nature { get; set; } = null!;

    public string NumeroBonLivraisonVente { get; set; } = null!;

    public string Opération { get; set; } = null!;

    public string? Utilisateur { get; set; }
}
