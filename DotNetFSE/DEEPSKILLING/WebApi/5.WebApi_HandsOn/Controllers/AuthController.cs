using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace _5.WebApi_HandsOn.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            var token = GenerateJSONWebToken(1, "Admin");
            return Ok(new { token });
        }

        private string GenerateJSONWebToken(int userId, string userRole)
        {
            // Use a key that is at least 32 characters (256 bits)
            var securityKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("ThisIsMySuperSecretJWTKeyForAuthentication2026@123"));

            var credentials = new SigningCredentials(
                securityKey,
                SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Role, userRole),
                new Claim("UserId", userId.ToString())
            };

            var token = new JwtSecurityToken(
                issuer: "mySystem",
                audience: "myUsers",
                claims: claims,
                expires: DateTime.Now.AddMinutes(10),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}