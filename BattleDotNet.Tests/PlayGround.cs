﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using System.Collections;

namespace BattleDotNet.Tests
{
    public class PlayGround
    {
        [Fact]
        public void Test()
        {
            var client = new WoWClient();
            Console.WriteLine(client.GetCharacter("xtek", "shattered-hand", fields: CharacterFields.Achievements).Achievements.CompletedAchievementIDs.Count());
        }
    }
}