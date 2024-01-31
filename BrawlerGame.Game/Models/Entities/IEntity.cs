namespace Models;
public abstract class IEntity {
    
    public int Health { get; set; }
    public int Speed { get; set; }
    public int HealValue { get; set; }
    public double DamageTakenMultiplier { get; set; }
    public Weapon? Weapon { get; set; } // null handling?
    public bool Attack(IEntity enemy){
        int Damage = (int) Weapon!.Damage;
        return enemy.TakeDamage(Health) > 0;
    }
    public int TakeDamage(int damage) {
        int takenDamage = (int) (damage * DamageTakenMultiplier);
        Health -= takenDamage;
        return takenDamage;
    }
    public int Heal() {
        int toBeHealed = HealValue;
        int healed = toBeHealed < Health ? toBeHealed : toBeHealed - Health;
        Health += healed;
        return healed;
    }
    public int getActionableSpeed() { //ignorenull should not be here
        return (int) (Speed * Weapon!.SpeedMultiplier);
    }

}

