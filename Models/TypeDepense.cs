using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class TypeDepense
{
    public string CodeTypeDepense { get; set; } = null!;

    public string Libelle { get; set; } = null!;

    public bool LieImportation { get; set; }
}
