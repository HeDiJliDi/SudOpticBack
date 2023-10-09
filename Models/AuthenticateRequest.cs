using System.ComponentModel.DataAnnotations;

namespace Sud_Optic_Api.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string NomUtilisateur { get; set; }

        [Required]
        public string MotDePasse { get; set; }
    }
}
