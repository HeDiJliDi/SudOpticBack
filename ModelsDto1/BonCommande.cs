using Sud_Optic_Api.Models;

namespace Sud_Optic_Api.ModelsDto1
{
    public class BonCommandeDTo
    {
        public BonCommandeVente bonCommande { get; set; }
        public List<LigneBonCommandeVente> ligneCommande { get; set; }
    }
}

