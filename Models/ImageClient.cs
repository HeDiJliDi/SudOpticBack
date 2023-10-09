using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ImageClient
{
    public string CodeClient { get; set; } = null!;

    public DateTime DateSaisie { get; set; }

    public string NomFichier { get; set; } = null!;

    public byte[]? ImageSaisie { get; set; }
}
