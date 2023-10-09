using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Tabless
{
    public string NumeroFactureVente { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string NumeroBonLivraisonVente { get; set; } = null!;

    public int NumeroOrdre { get; set; }
}
