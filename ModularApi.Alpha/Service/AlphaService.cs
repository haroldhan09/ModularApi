namespace ModularApi.Alpha.Service;

public interface IAlphaService
{
    void CreateAlpha(string name);
}

public class AlphaService : IAlphaService
{
    public void CreateAlpha(string name)
    {
        Console.WriteLine($"AlphaService Called: {name}");
    }
}
