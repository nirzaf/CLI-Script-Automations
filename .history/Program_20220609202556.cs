﻿using System.ComponentModel.DataAnnotations;
using CliWrap;
using CliWrap.Buffered;

namespace CLI_Script_Automations
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Services.PrintSum(1, 10);
        }
    }
}