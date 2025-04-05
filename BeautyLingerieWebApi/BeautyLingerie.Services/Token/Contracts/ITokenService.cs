using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyLingerie.Services.Token.Contracts
{
    public interface ITokenService
    {
        string GenerateJwtToken(string email);
    }
}
