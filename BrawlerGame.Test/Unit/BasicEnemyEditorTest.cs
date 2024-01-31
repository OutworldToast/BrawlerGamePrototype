namespace BrawlerGame.Test;

using Editors;
using Models;

public class BasicEnemyEditorTest {
    //tests should be modified upon implementation of Options

    class MockOptions : IOptions {
        //does nothing
    }

    [Fact]
    public void CreateEnemyTest() {
        // Arrange
        var options = new MockOptions();
        var basicEnemyEditor = new BasicEnemyEditor(options);

        // Act
        var enemy = basicEnemyEditor.CreateEnemy();

        // Assert
        Assert.IsType<BasicEnemy>(enemy);
    }

    [Fact]
    public void SetHealthValidTest() {
        // Arrange
        var options = new MockOptions();
        var basicEnemyEditor = new BasicEnemyEditor(options);

        // Act
        var enemy = basicEnemyEditor.CreateEnemy();
        basicEnemyEditor.SetHealth(enemy, 10);

        // Assert
        Assert.Equal(10, enemy.Health);
    }

    [Fact]
    public void SetSpeedValidTest() {
        // Arrange
        var options = new MockOptions();
        var basicEnemyEditor = new BasicEnemyEditor(options);

        // Act
        var enemy = basicEnemyEditor.CreateEnemy();
        basicEnemyEditor.SetSpeed(enemy, 10);

        // Assert
        Assert.Equal(10, enemy.Speed);
    }

    [Fact]
    public void SetHealValueValidTest() {
        // Arrange
        var options = new MockOptions();
        var basicEnemyEditor = new BasicEnemyEditor(options);

        // Act
        var enemy = basicEnemyEditor.CreateEnemy();
        basicEnemyEditor.SetHealValue(enemy, 10);

        // Assert
        Assert.Equal(10, enemy.HealValue);
    }

    [Fact]
    public void SetDamageTakenMultiplierValidTest() {
        // Arrange
        var options = new MockOptions();
        var basicEnemyEditor = new BasicEnemyEditor(options);

        // Act
        var enemy = basicEnemyEditor.CreateEnemy();
        basicEnemyEditor.SetDamageTakenMultiplier(enemy, 1.5);

        // Assert
        Assert.Equal(1.5, enemy.DamageTakenMultiplier);
    }
}