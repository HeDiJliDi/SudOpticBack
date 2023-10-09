using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class BonTransformation
{
    public string NumeroBonTransformation { get; set; } = null!;

    public DateTime DateBonTransformation { get; set; }

    public string CodeDepot { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public DateTime DateCreation { get; set; }

    public DateTime HeureCreation { get; set; }

    public string Observation { get; set; } = null!;

    public string CodeArticle { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public decimal Quantite { get; set; }

    public bool Bd { get; set; }

    public bool Bg { get; set; }

    public bool Face { get; set; }

    public bool Chd { get; set; }

    public bool Chg { get; set; }

    public bool Vd { get; set; }

    public bool Vg { get; set; }

    public bool Pont { get; set; }
}
