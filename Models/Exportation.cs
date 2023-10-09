using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Exportation
{
    public string NumeroExportation { get; set; } = null!;

    public DateTime DateExportation { get; set; }

    public string NomUtilisateur { get; set; } = null!;

    public string MoisExportation { get; set; } = null!;
}
