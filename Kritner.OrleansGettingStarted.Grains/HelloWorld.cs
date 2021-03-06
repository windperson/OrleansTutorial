﻿using System;
using System.Threading.Tasks;
using Kritner.OrleansGettingStarted.GrainInterfaces;
using Orleans;

namespace Kritner.OrleansGettingStarted.Grains
{
    public class HelloWorld : Grain, IHelloWorld
    {
        public Task<string> SayHello(string name)
        {
            return Task.FromResult($"Hello from grain [{this.GetGrainIdentity()}], eh {name}?");
        }
    }
}
