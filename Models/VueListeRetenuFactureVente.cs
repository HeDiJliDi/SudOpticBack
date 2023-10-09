using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeRetenuFactureVente
{
    public DateTime DateRetenuVente { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string? NomUtilisateur { get; set; }

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public decimal TotalRetenu { get; set; }

    public string NumeroRetenu { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public string Client { get; set; } = null!;
}
