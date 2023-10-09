using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueDetailRemplacementClient
{
    public string NewReglement { get; set; } = null!;

    public string NewReference { get; set; } = null!;

    public string AncienReglement { get; set; } = null!;

    public string AncienReference { get; set; } = null!;

    public decimal MontantRecu { get; set; }

    public string NewCodeModeReglement { get; set; } = null!;

    public string AncienCodeModeReglement { get; set; } = null!;
}
