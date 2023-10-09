using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class TraceDetailReglementClient
{
    public string NumeroPieceClient { get; set; } = null!;

    public string CodeModeReglement { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public DateTime DateMaj { get; set; }

    public DateTime HeureMaj { get; set; }

    public string TypeMaj { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;
}
