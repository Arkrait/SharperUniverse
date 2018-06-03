﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SharperUniverse.Core;

namespace SharperUniverse.Tests
{
    public class EmptyCommandBinding : IUniverseCommandBinding
    {
        private IIOHandler _ioHandler;
        public string CommandName { get; }

        public EmptyCommandBinding(string commandName)
        {
            CommandName = commandName;
        }

        [SharperInject]
        private void InitializeCommandRequirements(IIOHandler ioHandler)
        {
            _ioHandler = ioHandler;
        }

        public Task ProcessCommandAsync(List<string> args)
        {
            return Task.CompletedTask;
        }

        private Task ExecuteCommandAsync(int index, bool result)
        {
            return Task.CompletedTask;
        }
    }
}