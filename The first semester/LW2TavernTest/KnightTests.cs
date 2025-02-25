using System;
using Xunit;

public class KnightTests
{
    [Fact]
    public void Knight_LevelUp_ShouldIncreaseLevel()
    {
        var knight = new Knight("Артур");
        var initialLevel = knight.Level;

        knight.LevelUp();

        Assert.Equal(initialLevel + 1, knight.Level);
    }

    [Fact]
    public void Knight_ShouldReceiveItem()
    {
        var knight = new Knight("Артур");
        var weapon = new Weapon("Меч", "Увеличивает урон", 10, "Дракон");

        knight.AddItem(weapon);

        Assert.Contains(weapon, knight.Items);
    }

    [Fact]
    public void Knight_ShouldRemoveItem()
    {
        var knight = new Knight("Артур");
        var weapon = new Weapon("Меч", "Увеличивает урон", 10, "Дракон");

        knight.AddItem(weapon);
        knight.RemoveItem(weapon);

        Assert.DoesNotContain(weapon, knight.Items);
    }

    [Fact]
    public void Knight_Health_ShouldIncrease_WhenEatingFood()
    {
        var knight = new Knight("Артур");
        var food = new Food("Яблоко", "Восстанавливает 10 здоровья", 10);

        food.Use(knight);

        Assert.Equal(110, knight.Health);
    }

    [Fact]
    public void Knight_Health_ShouldDecrease_WhenAttackedByDragon()
    {
        var knight = new Knight("Артур");
        var dragon = new Dragon("Дракон", 20, 100, 1);

        dragon.Attack(knight);

        Assert.Equal(80, knight.Health);
    }

    [Fact]
    public void Knight_Health_ShouldDecrease_WhenAttackedByGhost()
    {
        var knight = new Knight("Артур");
        var ghost = new Ghost("Призрак", 10, 50, 1);

        ghost.Attack(knight);

        Assert.Equal(90, knight.Health);
    }

    [Fact]
    public void Knight_Health_ShouldDecrease_WhenAttackedByPlant()
    {
        var knight = new Knight("Артур");
        var plant = new Plant("Растение", 15, 50, 1);

        plant.Attack(knight);

        Assert.Equal(85, knight.Health);
    }

    [Fact]
    public void Knight_Health_ShouldDecrease_WhenAttackedByVampire()
    {
        var knight = new Knight("Артур");
        var vampire = new Vampire("Вампир", 25, 80, 1);

        vampire.Attack(knight);

        Assert.Equal(75, knight.Health);
    }
}
