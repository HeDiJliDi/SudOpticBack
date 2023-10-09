using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueSuivieMouvementStock
{
    public string CodeArticle { get; set; } = null!;

    public decimal Qtachat { get; set; }

    public decimal Qtvente { get; set; }

    public decimal QtstockActuel { get; set; }

    public string CodeMarque { get; set; } = null!;

    public string CodeFamille { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public decimal PrixVenteHt { get; set; }

    public decimal PrixVenteTtc { get; set; }

    public string LibelleFamille { get; set; } = null!;

    public string LibelleMarque { get; set; } = null!;

    public DateTime DateDernierVente { get; set; }

    public string NumeroBonLivraisonVente { get; set; } = null!;
}
