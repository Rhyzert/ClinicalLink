using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Interfaces
{
    public interface IAuthenticate
    {
        Task<bool> AuthenticateAsync(string username, string password);
        Task<bool> UserExists(string email);
        public string GenerateToken(int id, string email);
    }
}
