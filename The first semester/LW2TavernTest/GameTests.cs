using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavernTest
{
    using LW2.src;
    using System;
    using Xunit;

    public class GameTests
    {
        [Fact]
        public void Game_Adventure_ShouldProceedWithCombatAndTavern()
        {
            var game = new Game();
            var knight = new Knight("Артур");

            game.Start();
            game.Adventure(knight);

            Assert.True(knight.Health >= 0);
        }

        [Fact]
        public void Creature_Battle_ShouldDecreaseHealthOfKnightAndCreature()
        {
            var knight = new Knight("Артур");
            var dragon = new Dragon("Дракон", 20, 100, 1);
            var game = new Game();

            game.Battle(knight, dragon);

            Assert.True(knight.Health < 100);
            Assert.True(dragon.Health < 100);
        }
    }

}
