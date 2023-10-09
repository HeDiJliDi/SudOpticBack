using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class OrderDepotDemande
{
    public string CodeDepotDemandeur { get; set; } = null!;

    public string CodeDepotDemandant { get; set; } = null!;

    public int Ordre { get; set; }
}
