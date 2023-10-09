using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Camion
{
    public string CodeCamion { get; set; } = null!;

    public string CodeDepot { get; set; } = null!;

    public string Libelle { get; set; } = null!;

    public string Martricule { get; set; } = null!;

    public string Observation { get; set; } = null!;
}
