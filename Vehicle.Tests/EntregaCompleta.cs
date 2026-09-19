namespace Vehicle.Tests;

public class EntregaCompleta
{
    [Fact]
    public Task EjecucionCompleta()
    {
        var originalOut = Console.Out;
        var sw = new StringWriter();
        Console.SetOut(sw);

        try
        {
            Program.Main(Array.Empty<string>());
        }
        finally
        {
            Console.SetOut(originalOut);
        }

        return Verifier.Verify(sw.ToString());
    }
}
