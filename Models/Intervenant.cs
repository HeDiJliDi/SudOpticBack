using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class Intervenant
{
    public string CodeIntervenant { get; set; } = null!;

    public string CodeService { get; set; } = null!;

    public string NomPrenom { get; set; } = null!;
}
