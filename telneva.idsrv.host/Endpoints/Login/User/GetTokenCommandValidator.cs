using FluentValidation;

namespace telneva.idsrv.host.Endpoints.Login.User
{
    public class GetTokenCommandValidator : AbstractValidator<GetTokenCommand>
    {
        public GetTokenCommandValidator()
        {
            RuleFor(x => x.user).NotNull();
        }
    }
}
