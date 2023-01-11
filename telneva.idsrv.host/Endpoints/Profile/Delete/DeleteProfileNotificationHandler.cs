using MediatR;

namespace telneva.idsrv.host.Endpoints.Profile.Delete
{
    public class DeleteProfileNotificationHandler : IRequestHandler<DeleteProfileNotification, Profile>
    {
        public Task<Profile> Handle(DeleteProfileNotification request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}