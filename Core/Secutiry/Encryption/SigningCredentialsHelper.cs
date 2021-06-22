using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Secutiry.Encryption
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey secirityKey)
        {
            return new SigningCredentials(secirityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
