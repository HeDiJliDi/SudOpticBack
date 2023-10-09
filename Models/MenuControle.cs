using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class MenuControle
{
    public string NomMenu { get; set; } = null!;

    public string NomMenuParent { get; set; } = null!;

    public string Libelle { get; set; } = null!;
}
