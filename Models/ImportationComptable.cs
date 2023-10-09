using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ImportationComptable
{
    public string NumeroImportation { get; set; } = null!;

    public string DateImportation { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public string NomPiece { get; set; } = null!;
}
