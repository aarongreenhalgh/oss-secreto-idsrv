using FluentValidation;

namespace telneva.idsrv.host.Endpoints.Profile.Archive
{
    public class ArchiveProfileNotificationValidator : AbstractValidator<ArchiveProfileNotification>
    {
        public ArchiveProfileNotificationValidator()
        {
            RuleFor(x => x.id).NotNull();
        }
    }
}
