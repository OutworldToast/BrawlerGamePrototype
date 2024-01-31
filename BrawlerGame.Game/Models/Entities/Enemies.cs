using System.Reflection.Metadata.Ecma335;

namespace Models;
public class Armoured : IEnemy {
    public int Health { get; set; } = 100;
    public int HealValue { get; set; } = 10;
    public int Speed { get; set; } = 1;
    public double DamageTakenMultiplier { get; set; } = 0.5;
    public bool Attack(IEnemy enemy) {
        return enemy.TakeDamage(10) <= 0;
    }

}

public class Scout : IEnemy {
    public int Health { get; set; } = 50;
    public int HealValue { get; set; } = 50;
    public int Speed { get; set; } = 2;
    public double DamageTakenMultiplier { get; set; } = 1.0;
    public bool Attack(IEnemy enemy) {
        return enemy.TakeDamage(10) <= 0;
    }
    
}