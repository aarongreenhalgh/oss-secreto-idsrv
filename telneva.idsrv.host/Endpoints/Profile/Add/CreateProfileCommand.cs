using MediatR;

namespace telneva.idsrv.host.Endpoints.Profile.Add
{
    public record CreateProfileCommand(Profile profile) : IRequest<Profile>;
}