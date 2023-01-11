using FluentValidation;

namespace telneva.idsrv.host.Endpoints.Profile.Delete
{
    public class DeleteProfileNotificationValidator : AbstractValidator<DeleteProfileNotification>
    {
        public DeleteProfileNotificationValidator()
        {
            RuleFor(x => x.id).NotNull();
        }
    }
}
