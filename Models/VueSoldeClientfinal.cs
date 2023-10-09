using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueSoldeClientfinal
{
    public string CodeClient { get; set; } = null!;

    public decimal? TotalDebit { get; set; }

    public decimal? TotalCredit { get; set; }
}
