using MediatR;

namespace telneva.idsrv.host.Endpoints.Profile.Delete
{
    public record DeleteProfileNotification(Guid id) : IRequest<Profile>;
}