namespace BrawlerGame.Test;

using Editors;

public class WeaponEditorTest { //tests should be modified upon implementation of Options

    class MockOptions : IOptions {
        //does nothing
    }

    [Fact]
    public void CreateWeaponTest() {
        // Arrange
        var options = new MockOptions();
        var weaponEditor = new WeaponEditor(options);

        // Act
        var weapon = weaponEditor.CreateWeapon();

        // Assert
        Assert.NotNull(weapon);
    }

    [Fact]
    public void SetNameValidTest() {
        // Arrange
        var options = new MockOptions();
        var weaponEditor = new WeaponEditor(options);

        // Act
        var weapon = weaponEditor.CreateWeapon();
        weaponEditor.SetName(weapon, "TestName");

        // Assert
        Assert.Equal("TestName", weapon.Name);
    }

    [Fact]
    public void SetDamageValidTest() {
        // Arrange
        var options = new MockOptions();
        var weaponEditor = new WeaponEditor(options);

        // Act
        var weapon = weaponEditor.CreateWeapon();
        weaponEditor.SetDamage(weapon, 10);

        // Assert
        Assert.Equal(10, weapon.Damage);
    }

    [Fact]
    public void SetSpeedMultiplierValidTest() {
        // Arrange
        var options = new MockOptions();
        var weaponEditor = new WeaponEditor(options);

        // Act
        var weapon = weaponEditor.CreateWeapon();
        weaponEditor.SetSpeedMultiplier(weapon, 1.5);

        // Assert
        Assert.Equal(1.5, weapon.SpeedMultiplier);
    }
}