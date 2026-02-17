using JWTAuthentication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JwtSettings _jwtsettings;
        public AuthController(JwtSettings jwtsettings)
        {
            _jwtsettings = jwtsettings;
        }

        [HttpGet]
        [Authorize]

        public IActionResult Get()

        {

            return Ok(new { value = "This is a protected view" });

        }
        [HttpPost("token")]
        public IActionResult GenerateToken()
        {
            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, "testuser"),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_jwtsettings.Secret));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _jwtsettings.Issuer,
                audience: _jwtsettings.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(_jwtsettings.ExpiryInMin),
                signingCredentials: creds
            );

            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }
        
        
    }

}