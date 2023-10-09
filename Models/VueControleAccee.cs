using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueControleAccee
{
    public string NomMenu { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;

    public bool Choix { get; set; }

    public string NomMenuParent { get; set; } = null!;

    public string Libelle { get; set; } = null!;
}
