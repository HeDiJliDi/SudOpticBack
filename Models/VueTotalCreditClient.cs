using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueTotalCreditClient
{
    public string CodeClient { get; set; } = null!;

    public decimal? TotalRecu { get; set; }
}
