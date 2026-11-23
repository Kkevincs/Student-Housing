using API.Repository.Models;
using DotNetEnv;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API.API.BLL.Services
{
    public class AuthenticationService
    {
        private readonly IConfiguration _config;

        public AuthenticationService(IConfiguration config)
        {
            _config = config;
        }

        public string HashPassword(string password)
        {
            var hasher = new PasswordHasher<Student>();

            return hasher.HashPassword(null!, password);
        }

        public bool VerifyPassword(Student student, string password)
        {
            var hasher = new PasswordHasher<Student>();

            var result = hasher.VerifyHashedPassword(
                student,
                student.PasswordHash,
                password
            );

            return result != PasswordVerificationResult.Failed;
        }
        public string GenerateToken(int userId, string role)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                new Claim(ClaimTypes.Role, role)
            };

            var jwtKey = _config["JWT_KEY"];

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(jwtKey));

            var credentials = new SigningCredentials(
                key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
