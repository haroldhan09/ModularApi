namespace ModularApi.Beta.Service;

public interface IBetaService
{
    void CreateBeta(string name);
}

public class BetaService : IBetaService
{
    public void CreateBeta(string name)
    {
        var newName = $"{name}-BETA";
        Console.WriteLine($"BetaService Called: {newName}");
    }
}