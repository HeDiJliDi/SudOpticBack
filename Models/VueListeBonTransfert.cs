using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeBonTransfert
{
    public string NumeroBonTransfert { get; set; } = null!;

    public DateTime DateBonTransfert { get; set; }

    public string DepotSource { get; set; } = null!;

    public string DepotDestination { get; set; } = null!;

    public decimal TotalHt { get; set; }

    public decimal TotalTva { get; set; }

    public decimal TotalTtc { get; set; }

    public string Observation { get; set; } = null!;

    public bool Valider { get; set; }

    public DateTime DateRetour { get; set; }

    public string CodeCamion { get; set; } = null!;
}
