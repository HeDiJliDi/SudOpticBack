using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class EntetRemplacementClient
{
    public string NumeroReMplacementClient { get; set; } = null!;

    public DateTime DateReglement { get; set; }

    public string CodeClient { get; set; } = null!;

    public decimal TotalBrute { get; set; }

    public decimal TotalAvance { get; set; }

    public decimal TotalRetenu { get; set; }

    public decimal TotalNet { get; set; }

    public decimal TotalRecu { get; set; }

    public string NomUtilisateur { get; set; } = null!;

    public DateTime? DateCreation { get; set; }

    public DateTime? HeureCreation { get; set; }

    public string Observation { get; set; } = null!;

    public string? TypeReglement { get; set; }

    public decimal Remise { get; set; }

    public bool Virtuel { get; set; }

    public string RaisonSociale { get; set; } = null!;
}
