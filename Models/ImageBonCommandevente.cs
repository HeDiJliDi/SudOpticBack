using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ImageBonCommandevente
{
    public string NumeroBonCommandeVente { get; set; } = null!;

    public byte[]? Image1 { get; set; }

    public byte[]? Image2 { get; set; }
}
