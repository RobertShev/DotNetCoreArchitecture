using DotNetCoreArchitecture.Model;

namespace DotNetCoreArchitecture.Domain
{
    public interface IUserDomainService
    {
        void GenerateHash(SignInModel signInModel);

        TokenModel GenerateToken(SignedInModel signedInModel);
    }
}
