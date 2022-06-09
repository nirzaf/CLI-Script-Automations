using System.ComponentModel.DataAnnotations;
using CliWrap;
using CliWrap.Buffered;

namespace CLI_Script_Automations
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var result = await Cli.Wrap("dotnet")
                        .WithArguments("--version")
                        .ExecuteBufferedAsync();

            var version = result.StandardOutput.Trim();
            Print($"dotnet version: {version}");
                
            var pal = GetPal();
            Print(pal.ToString());
            Read();
        }
        
}