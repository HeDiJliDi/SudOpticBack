using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class TemporaireSuivieStock
{
    public string CodeArticle { get; set; } = null!;

    public decimal Qtachat { get; set; }

    public decimal Qtvente { get; set; }

    public decimal QtstockActuel { get; set; }
}
