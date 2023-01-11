using MediatR;

namespace telneva.idsrv.host.Endpoints.Profile.Get
{
    public class GetProfileHandler : IRequestHandler<GetProfileCommand, Profile>
    {
        public Task<Profile> Handle(GetProfileCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}