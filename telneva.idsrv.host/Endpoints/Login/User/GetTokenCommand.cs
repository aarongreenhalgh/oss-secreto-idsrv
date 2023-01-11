using MediatR;
using telneva.idsrv.host.Helpers;

namespace telneva.idsrv.host.Endpoints.Login.User
{
    public record GetTokenCommand(Users user) : IRequest<test>;
}