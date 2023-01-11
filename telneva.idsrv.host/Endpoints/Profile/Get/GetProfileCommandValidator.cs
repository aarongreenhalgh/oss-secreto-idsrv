using FluentValidation;

namespace telneva.idsrv.host.Endpoints.Profile.Get
{
    public class GetProfileCommandValidator : AbstractValidator<GetProfileCommand>
    {
        public GetProfileCommandValidator()
        {
            RuleFor(x => x.id).NotNull();
        }
    }
}
