using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class HistoriqueSoldeClient
{
    public string CodeClient { get; set; } = null!;

    public DateTime DateSolde { get; set; }

    public decimal SoldeDebitClient { get; set; }

    public string NumeroEtat { get; set; } = null!;

    public decimal SoldeCreditClient { get; set; }
}
