using MediatR;

namespace ModuleApi.Common.Features.Beta.Queries;

public class GetBetaNameById : IRequest<string>
{
    public int Id { get; set; }
}