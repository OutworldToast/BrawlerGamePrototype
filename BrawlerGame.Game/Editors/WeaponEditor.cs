using Models;

namespace Editors;

public class WeaponEditor { //should implement additional logic for weapon creation
    private readonly IOptions? _options;

    public WeaponEditor(IOptions? options) {
        _options = options;
    }

    public Weapon CreateWeapon() {
        return new Weapon();
    }

    public void SetName(Weapon weapon, string name) {
        weapon.Name = name;
    }

    public void SetDamage(Weapon weapon, int damage) {
        weapon.Damage = damage;
    }

    public void SetSpeedMultiplier(Weapon weapon, double speedMultiplier) {
        weapon.SpeedMultiplier = speedMultiplier;
    }
}