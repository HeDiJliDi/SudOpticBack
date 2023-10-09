using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Sud_Optic_Api.Context;
using System.IdentityModel.Tokens.Jwt;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Text;
using Sud_Optic_Api.Context;
using Sud_Optic_Api.Models;

namespace Sud_Optic_Api.Controllers
{
 

    [ApiController]
    public class Login : ControllerBase
    {

        I2S_SudOpticContext _context;

        IConfiguration _configuration;

        public Login(IConfiguration configuration, I2S_SudOpticContext context)
        {
            _configuration = configuration;
             _context = context;
        }



        [HttpPost]
        [Route("api/login")]
        public async Task<IActionResult> PostLoginDetails(AuthenticateRequest _userData)
        {
            if (_userData != null)
            {
                var utilisateur = _context.Utilisateurs
                    .Where(e => e.NomUtilisateur == _userData.NomUtilisateur && e.MotDePasse == _userData.MotDePasse)
                    .FirstOrDefault();
                if (utilisateur == null)
                {
                    return BadRequest("Invalid Credentials");
                }
                else
                {
                    var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("NomUtilisateur", utilisateur.NomUtilisateur.ToString()),
                        new Claim("MotDePasse", utilisateur.MotDePasse),
                        new Claim(ClaimTypes.Role,utilisateur.CodeFonction)
                    };
                    var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Issuer = _configuration["Jwt:Issuer"],
                        Audience = _configuration["Jwt:Audience"],
                        Expires = DateTime.UtcNow.AddMinutes(300),
                        SigningCredentials = new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256),
                        Subject = new ClaimsIdentity(claims)
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    var _token = tokenHandler.WriteToken(token);
                    return Ok(new { token = _token, UserMessage = "Login Success" });
                }
            }
            else
            {
                return BadRequest("No Data Posted");
            }
        }



    }
}