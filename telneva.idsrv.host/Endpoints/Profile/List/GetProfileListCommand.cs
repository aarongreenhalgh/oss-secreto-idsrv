using MediatR;

namespace telneva.idsrv.host.Endpoints.Profile.List
{
    public record GetProfileListCommand : IRequest<Profile>;
}