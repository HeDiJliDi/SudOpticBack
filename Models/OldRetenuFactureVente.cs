using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class OldRetenuFactureVente
{
    public string NumeroFactureVente { get; set; } = null!;

    public string CodeRetenu { get; set; } = null!;

    public DateTime DateRetenuVente { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public decimal TauxRetenu { get; set; }

    public decimal MontantRetenu { get; set; }

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }
}
