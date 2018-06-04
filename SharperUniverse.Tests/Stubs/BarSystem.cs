﻿using System;
using System.Threading.Tasks;
using SharperUniverse.Core;

namespace SharperUniverse.Tests.Stubs
{
    class BarSystem : BaseSharperSystem<BarComponent>
    {
        public bool TestSwitch { get; set; }

        public BarSystem(GameRunner game) : base(game)
        {
            TestSwitch = false;
        }

        public override Task CycleUpdateAsync(Func<string, Task> outputHandler)
        {
            return Task.CompletedTask;
        }
    }
}
