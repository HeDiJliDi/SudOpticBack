using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Preference
{
    public string NomUtilisateur { get; set; } = null!;

    public string NomGrid { get; set; } = null!;

    public string Script { get; set; } = null!;
}
