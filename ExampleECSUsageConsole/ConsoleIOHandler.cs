﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharperUniverse.Core;
using SharperUniverse.Utilities;

namespace ExampleECSUsageConsole
{
    class ConsoleIOHandler : IIOHandler
    {
        public async Task<(string CommandName, List<string> Args, IUniverseCommandSource CommandSource)> GetInputAsync()
        {
            var inputStr = await Console.In.ReadLineAsync();
            var inputSplit = inputStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (inputSplit.Length >= 2)
            {
                var returnList = inputSplit.SubArray(1, inputSplit.Length - 1);
                return (inputSplit[0], returnList.ToList(), new TestCommandSource(0));
            }

            if (inputSplit.Length > 1 && inputSplit[0] != string.Empty) return (inputSplit[0], new List<string>(), new TestCommandSource(0));

            return ("", new List<string>(), new TestCommandSource(0));
        }

        public async Task SendOutputAsync(string outputText)
        {
            await Console.Out.WriteLineAsync(outputText);
        }
    }
}
