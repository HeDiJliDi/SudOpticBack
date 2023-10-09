using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class TraceBonLivraisonVente
{
    public string NumeroBonLivraisonVente { get; set; } = null!;

    public DateTime DateMaj { get; set; }

    public DateTime HeureMaj { get; set; }

    public string TypeMaj { get; set; } = null!;

    public decimal AncienTotal { get; set; }

    public decimal NouveauTotal { get; set; }

    public string NomUtilisateur { get; set; } = null!;
}
