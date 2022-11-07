﻿using Dungeon_Crawl.src.Objects.DynamicObjects;

namespace Dungeon_Crawl.src.Monsters;

internal class Boss : Monster
{
    public Boss(Position position) : base(position)
    {
    }

    protected override string Symbol => "B";

    internal override int experienceToGain => 100;

    public override string Render()
    {
        throw new NotImplementedException();
    }

    public override void Update()
    {
        throw new NotImplementedException();
    }
}

