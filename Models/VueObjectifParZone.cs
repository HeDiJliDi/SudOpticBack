using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueObjectifParZone
{
    public int Annnee { get; set; }

    public int Mois { get; set; }

    public string CodeSemaine { get; set; } = null!;

    public int NombrePiece { get; set; }

    public string CodeLivreur { get; set; } = null!;

    public string? NomPrenom { get; set; }

    public string? Zone { get; set; }
}
