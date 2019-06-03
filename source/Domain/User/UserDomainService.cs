using DotNetCore.Extensions;
using DotNetCore.Security;
using DotNetCoreArchitecture.Model;
using System.Collections.Generic;
using System.Security.Claims;

namespace DotNetCoreArchitecture.Domain
{
    public class UserDomainService : IUserDomainService
    {
        public UserDomainService
        (
            IHash hash,
            IJsonWebToken jsonWebToken
        )
        {
            Hash = hash;
            JsonWebToken = jsonWebToken;
        }

        private IHash Hash { get; }

        private IJsonWebToken JsonWebToken { get; }

        public void GenerateHash(SignInModel signInModel)
        {
            signInModel.Password = Hash.Create(signInModel.Password);
        }

        public TokenModel GenerateToken(SignedInModel signedInModel)
        {
            var claims = new List<Claim>();

            claims.AddSub(signedInModel.UserId.ToString());

            claims.AddRoles(signedInModel.Roles.ToString().Split(", "));

            var token = JsonWebToken.Encode(claims);

            return new TokenModel(token);
        }
    }
}
