using System;
using System.Collections.Generic;

namespace Sud_Optic_Api.Models;

public partial class VueListeReceptionMateriel
{
    public string NumeroReception { get; set; } = null!;

    public string CodeClient { get; set; } = null!;

    public DateTime DateCreation { get; set; }

    public DateTime DateReception { get; set; }

    public DateTime HeureCreation { get; set; }

    public string NomUtilisateur { get; set; } = null!;

    public string LibellePanne { get; set; } = null!;

    public string NumeroEtat { get; set; } = null!;

    public string Etat { get; set; } = null!;

    public string Client { get; set; } = null!;

    public string Piece { get; set; } = null!;
}
