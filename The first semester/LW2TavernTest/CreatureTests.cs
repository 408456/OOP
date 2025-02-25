using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using Xunit;

public class CreatureTests
{
    [Fact]
    public void Dragon_Attack_ShouldReduceKnightHealth()
    {
        var knight = new Knight("Артур");
        var dragon = new Dragon("Колхидский дракон", 20, 100, 1);

        dragon.Attack(knight);

        Assert.Equal(80, knight.Health);
    }

    [Fact]
    public void Ghost_Attack_ShouldReduceKnightHealth()
    {
        var knight = new Knight("Артур");
        var ghost = new Ghost("Банши", 10, 50, 1);

        ghost.Attack(knight);

        Assert.Equal(90, knight.Health);
    }

    [Fact]
    public void Plant_Attack_ShouldReduceKnightHealth()
    {
        var knight = new Knight("Артур");
        var plant = new Plant("Плентящее растение", 15, 50, 1);

        plant.Attack(knight);

        Assert.Equal(85, knight.Health);
    }

    [Fact]
    public void Vampire_Attack_ShouldReduceKnightHealth()
    {
        var knight = new Knight("Артур");
        var vampire = new Vampire("Вампир", 25, 80, 1);

        vampire.Attack(knight);

        Assert.Equal(75, knight.Health);
    }
}
