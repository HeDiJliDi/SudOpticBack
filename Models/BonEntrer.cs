using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class BonEntrer
{
    public string NumeroBonEntrer { get; set; } = null!;

    public DateTime DateBonEntrer { get; set; }

    public string CodeDepot { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string Observation { get; set; } = null!;
}
