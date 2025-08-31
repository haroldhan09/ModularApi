using ModularApi.Beta.Service;
using ModuleApi.Common.Features.Beta.Commands;
using ModuleApi.Common.Features.Beta.DTO;

namespace ModularApi.Beta.Features.Commands;

internal class CreateBetaCommandHandler(IBetaService betaService) : ICreateBetaCommandHandler
{
    public Task<CreateBetaResponse> Handle(CreateBetaCommand request, CancellationToken cancellationToken)
    {
        var newName = $"{request.Name}-BETA";
        betaService.CreateBeta(request.Name);

        return Task.FromResult(new CreateBetaResponse()
        {
            Id = 1,
            Name = newName
        });
    }
}