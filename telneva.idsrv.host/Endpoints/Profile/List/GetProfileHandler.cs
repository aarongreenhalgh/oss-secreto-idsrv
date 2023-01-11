using MediatR;

namespace telneva.idsrv.host.Endpoints.Profile.List
{
    public class GetProfileListHandler : IRequestHandler<GetProfileListCommand, Profile>
    {
        public Task<Profile> Handle(GetProfileListCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
