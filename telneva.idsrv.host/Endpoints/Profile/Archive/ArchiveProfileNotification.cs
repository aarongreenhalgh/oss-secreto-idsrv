using MediatR;

namespace telneva.idsrv.host.Endpoints.Profile.Archive
{
    public record ArchiveProfileNotification(Guid id) : IRequest<Profile>;
}