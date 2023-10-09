using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class CourbeArticle
{
    public string CodeArticle { get; set; } = null!;

    public string Pointure { get; set; } = null!;

    public decimal Courbe { get; set; }
}
