namespace BrawlerGame.Test;

using Editors;

public class WeaponEnemyIntegrationTest {
    //tests should be modified upon implementation of Options

    class MockOptions : IOptions {
        //does nothing
    }

    [Fact]
    public void CreateEnemyTest() {
        // Arrange
        var options = new MockOptions();
        var weaponEditor = new WeaponEditor(options);
        var basicEnemyEditor = new BasicEnemyEditor(options);

        // Act
        var enemy = basicEnemyEditor.CreateEnemy();
        var weapon = weaponEditor.CreateWeapon();
        basicEnemyEditor.SetWeapon(enemy, weapon);

        // Assert
        Assert.Equal(weapon, enemy.Weapon);
    }

}