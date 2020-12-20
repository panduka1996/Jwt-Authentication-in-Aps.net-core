using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtToken
{
    public interface IJwtAuthenticationManager
    {
        public string Authenticated(string username, string password);
    }
}
