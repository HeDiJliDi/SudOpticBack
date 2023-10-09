using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Lot
{
    public string NumeroLot { get; set; } = null!;

    public string CodeDepot { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public decimal Quantite { get; set; }

    public decimal PrixAchatNet { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }
}
