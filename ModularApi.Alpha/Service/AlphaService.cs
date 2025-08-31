using ModularApi.Alpha.Models;

namespace ModularApi.Alpha.Service;

public interface IAlphaService
{
    AlphaModel GetAlpha(int alphaId);
    
    void CreateAlpha(string name);
}

public class AlphaService : IAlphaService
{
    public AlphaModel GetAlpha(int alphaId)
    {
        return new AlphaModel()
        {
            AlphaId = alphaId,
            AlphaName = "NameFromAlpha"
        };
    }

    public void CreateAlpha(string name)
    {
        var newName = $"{name}-ALPHA";
        Console.WriteLine($"AlphaService Called: {newName}");
    }
}
