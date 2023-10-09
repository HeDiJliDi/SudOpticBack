using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ReservationArticleDansDepot
{
    public string NumeroBonCommandeVente { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public string CodeDepotDemendeur { get; set; } = null!;

    public string CodeDepotDemandant { get; set; } = null!;

    public decimal Quantite { get; set; }

    public bool Valider { get; set; }

    public bool Telephone { get; set; }

    public bool Annuler { get; set; }

    public bool Cloturer { get; set; }
}
