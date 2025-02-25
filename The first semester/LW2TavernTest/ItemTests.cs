using System;
using Xunit;

public class ItemTests
{
    [Fact]
    public void Food_Use_ShouldRestoreHealth()
    {
        var knight = new Knight("Артур");
        var food = new Food("Зелье", "Восстанавливает 30 здоровья", 30);

        food.Use(knight);

        Assert.Equal(130, knight.Health);
    }

    [Fact]
    public void MagicItem_Use_ShouldInvokeAbility()
    {
        var knight = new Knight("Артур");
        var magicItem = new MagicItem("Сила", "Увеличивает силу", "Увеличение силы на 10");

        magicItem.Use(knight);

        // Проверка, что метод Use вызвал нужное сообщение
    }

    [Fact]
    public void Weapon_Use_ShouldAddDamage()
    {
        var knight = new Knight("Артур");
        var weapon = new Weapon("Меч", "Увеличивает урон", 15, "Дракон");

        weapon.Use(knight);

        Assert.Contains(weapon, knight.Items);
    }
}
