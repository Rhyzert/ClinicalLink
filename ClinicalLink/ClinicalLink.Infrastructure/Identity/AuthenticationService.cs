using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ClinicalLink.Infrastructure;
using ClinicalLink.Infrastructure.Interface;
using Microsoft.Extensions.Configuration;

namespace ClinicalLink.Infrastructure.Identity
{
    /*public class AuthenticationService : IAuthenticate
    {
        private readonly SqlContext _context;
        private readonly IConfiguration _configuration;

        public AuthenticationService(SqlContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public Task<bool> AuthenticateAsync(string email, string password)
        {
            var usuario = _context.Usuarios.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
            //if (usuario == null) {
            //    return false;

            //};
            using var hmac = new HMACSHA512(usuario.PasswordSalt);


        }

        public string GenerateToken(int id, string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExists(string email)
        {
            throw new NotImplementedException();
        }
    }*/
}
