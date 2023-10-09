using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ExonerationClient
{
    public string CodeClient { get; set; } = null!;

    public string NumeroExoneration { get; set; } = null!;

    public DateTime? DateDebutExoneration { get; set; }

    public DateTime? DateFinExoneration { get; set; }

    public bool Actif { get; set; }
}
