namespace Models;

public class Weapon {

    public string Name { get; set; } = "Fists of Justice";
    //public string Type { get; set; } = "Fists";
    public int Damage { get; set; } = 1;
    public double SpeedMultiplier { get; set; } = 1;
    
    public void Upgrade() {}
    
}