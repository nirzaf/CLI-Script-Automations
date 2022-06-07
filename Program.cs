using CliWrap;
using CliWrap.Buffered;

namespace CLI_Script_Automations
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var cliResponse = await Cli.Wrap("dotnet")
                .WithArguments( new[] {"--version" })
                .ExecuteBufferedAsync();
            Console.WriteLine(cliResponse.StandardOutput);

        }
    }
}