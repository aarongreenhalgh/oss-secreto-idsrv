using MediatR;

namespace telneva.idsrv.host.Endpoints.Profile.Get
{
    public record GetProfileCommand(Guid id) : IRequest<Profile>;
}