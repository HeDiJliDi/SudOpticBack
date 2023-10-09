using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeExportation
{
    public string NumeroExportation { get; set; } = null!;

    public DateTime DateExportation { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string NomUtilisateur { get; set; } = null!;
}
