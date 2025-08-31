using ModuleApi.Common.Features.Beta.Queries;

namespace ModularApi.Beta.Features.Queries;

internal class GetBetaNameByIdHandler : IGetBetaNameByIdHandler
{
    public Task<string> Handle(GetBetaNameById request, CancellationToken cancellationToken)
    {
        return Task.FromResult("NameFromBeta");
    }
}