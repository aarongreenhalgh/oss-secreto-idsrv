using MediatR;
using telneva.idsrv.host.Helpers;

namespace telneva.idsrv.host.Endpoints.Login.User
{
    public class GetTokenHandler : IRequestHandler<GetTokenCommand, test>
    {
        public Task<test> Handle(GetTokenCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}