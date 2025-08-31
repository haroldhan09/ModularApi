using MediatR;
using Microsoft.AspNetCore.Mvc;
using ModularApi.Alpha.Service;
using ModuleApi.Common.Features.Beta.Commands;
using ModuleApi.Common.Features.Beta.Queries;

namespace ModularApi.Alpha.Api;

[ApiController]
[Route("api/alpha")]
public class AlphaController(IAlphaService alphaService, IMediator mediator)
{
    [HttpGet("{alphaId}")]
    public async Task<IActionResult> Get(int alphaId)
    {
        var model = alphaService.GetAlpha(alphaId);
        var betaCmd = new GetBetaNameById() { Id = alphaId };
        var result = await mediator.Send(betaCmd);
        model.BetaName = result;
        
        return new OkObjectResult(model);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateAlphaRequest request)
    {
        alphaService.CreateAlpha(request.Name);
        
        var createBetaCommand = new CreateBetaCommand { Name = request.Name };
        var response = await mediator.Send(createBetaCommand);
        
        Console.WriteLine($"AlphaController: {response!.Id} / {response.Name}");
        return new NoContentResult();
    }
}

/// <summary>
/// Request object for [POST] /api/alpha
/// </summary>
public class CreateAlphaRequest
{   
    public string Name { get; set; } = string.Empty;
}