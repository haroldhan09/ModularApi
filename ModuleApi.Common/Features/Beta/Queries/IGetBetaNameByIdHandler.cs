using MediatR;

namespace ModuleApi.Common.Features.Beta.Queries;

public interface IGetBetaNameByIdHandler : IRequestHandler<GetBetaNameById, string>
{
}