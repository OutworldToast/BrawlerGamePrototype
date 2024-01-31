namespace Models;
public interface IEnemy {
    
    int Health { get; set; }
    int Speed { get; set; }
    int HealValue { get; set; }
    double DamageTakenMultiplier { get; set; }
    bool Attack(IEnemy enemy);
    int TakeDamage(int damage) {
        int takenDamage = (int) (damage * DamageTakenMultiplier);
        Health -= takenDamage;
        return takenDamage;
    }
    int Heal() {
        int toBeHealed = HealValue;
        int healed = toBeHealed < Health ? toBeHealed : toBeHealed - Health;
        Health += healed;
        return healed;
    }

}

