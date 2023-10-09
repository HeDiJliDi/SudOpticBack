using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class DroitAcce
{
    public string NomMenu { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public bool Autoriser { get; set; }
}
