using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeLot
{
    public string NumeroLot { get; set; } = null!;

    public string CodeDepot { get; set; } = null!;

    public string Depot { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public decimal Quantite { get; set; }

    public decimal PrixAchatNet { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public string Etat { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }
}
