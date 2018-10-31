﻿using System;
namespace InvaderGame
{
    class PowerTower : Tower
    {
        protected override int Power { get; } = 2;

        public PowerTower(MapLocation mapLocation) : base(mapLocation)
        {
        }
    }
}
