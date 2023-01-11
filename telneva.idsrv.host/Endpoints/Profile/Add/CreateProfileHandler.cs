using MediatR;

namespace telneva.idsrv.host.Endpoints.Profile.Add
{
    public class CreateProfileHandler : IRequestHandler<CreateProfileCommand, Profile>
    {
        public Task<Profile> Handle(CreateProfileCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
