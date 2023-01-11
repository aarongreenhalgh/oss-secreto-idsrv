using FluentValidation;

namespace telneva.idsrv.host.Endpoints.Profile.Add
{
    public class CreateProfileCommandValidator : AbstractValidator<CreateProfileCommand>
    {
        public CreateProfileCommandValidator()
        {
            RuleFor(x => x.profile).NotEmpty();
        }
    }
}
