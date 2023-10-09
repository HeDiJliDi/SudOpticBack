using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeMouvementClient
{
    public string Client { get; set; } = null!;

    public string NumeroPiece { get; set; } = null!;

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }
}
