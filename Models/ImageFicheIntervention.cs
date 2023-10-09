using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class ImageFicheIntervention
{
    public string NumeroFicheIntervention { get; set; } = null!;

    public string NomFichier { get; set; } = null!;

    public DateTime DateSaisie { get; set; }

    public byte[]? ImageSaisie { get; set; }
}
