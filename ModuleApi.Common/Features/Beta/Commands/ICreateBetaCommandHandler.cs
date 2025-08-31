using MediatR;
using ModuleApi.Common.Features.Beta.DTO;

namespace ModuleApi.Common.Features.Beta.Commands;

public interface ICreateBetaCommandHandler : IRequestHandler<CreateBetaCommand, CreateBetaResponse>
{
}