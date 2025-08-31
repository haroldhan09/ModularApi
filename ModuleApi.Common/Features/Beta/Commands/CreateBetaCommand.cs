using MediatR;
using ModuleApi.Common.Features.Beta.DTO;

namespace ModuleApi.Common.Features.Beta.Commands;

public class CreateBetaCommand : IRequest<CreateBetaResponse>
{
    public string Name { get; init; } = string.Empty;
}