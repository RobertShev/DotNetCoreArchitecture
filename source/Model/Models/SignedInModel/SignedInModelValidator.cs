using DotNetCore.Validation;
using DotNetCoreArchitecture.CrossCutting.Resources;
using FluentValidation;

namespace DotNetCoreArchitecture.Model
{
    public sealed class SignedInModelValidator : Validator<SignedInModel>
    {
        public SignedInModelValidator()
        {
            WithMessage(Texts.LoginPasswordInvalid);
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.Roles).NotEmpty();
        }
    }
}
