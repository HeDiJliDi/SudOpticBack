using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Iban
{
    public string CodeIban { get; set; } = null!;

    public string? Libelle { get; set; }
}
