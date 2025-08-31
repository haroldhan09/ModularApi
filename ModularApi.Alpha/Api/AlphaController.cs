using MediatR;
using Microsoft.AspNetCore.Mvc;
using ModularApi.Alpha.Service;
using ModuleApi.Common.Features.Beta.Commands;

namespace ModularApi.Alpha.Api;

[ApiController]
[Route("api/[controller]")]
public class AlphaController(IAlphaService alphaService, IMediator mediator)
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateAlphaRequest request)
    {
        var newName = $"{request.Name}-ALPHA";
        alphaService.CreateAlpha(newName);

        var createBetaCommand = new CreateBetaCommand { Name = request.Name };
        var response = await mediator.Send(createBetaCommand);
        
        Console.WriteLine($"AlphaController: {response.Id} / {response.Name}");
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