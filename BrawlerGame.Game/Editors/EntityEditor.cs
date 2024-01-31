using Models;

namespace Editors;

public abstract class EntityEditor {
    private readonly IOptions? _options;

    public EntityEditor(IOptions? options) {
        _options = options;
    }

    public abstract IEntity CreateEnemy();

    public void SetHealth(IEntity entity, int health) {
        entity.Health = health;
    }

    public void SetSpeed(IEntity entity, int speed) {
        entity.Speed = speed;
    }

    public void SetHealValue(IEntity entity, int healValue) {
        entity.HealValue = healValue;
    }

    public void SetDamageTakenMultiplier(IEntity entity, double damageTakenMultiplier) {
        entity.DamageTakenMultiplier = damageTakenMultiplier;
    }

    public void SetWeapon(IEntity entity, Weapon weapon) {
        entity.Weapon = weapon;
    }
}