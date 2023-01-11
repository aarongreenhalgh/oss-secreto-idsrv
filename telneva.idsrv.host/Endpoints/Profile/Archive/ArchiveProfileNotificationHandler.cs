using MediatR;

namespace telneva.idsrv.host.Endpoints.Profile.Archive
{
    public class ArchiveProfileNotificationHandler : IRequestHandler<ArchiveProfileNotification, Profile>
    {
        public Task<Profile> Handle(ArchiveProfileNotification request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}