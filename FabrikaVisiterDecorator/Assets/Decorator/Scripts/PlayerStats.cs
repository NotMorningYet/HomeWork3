
public class PlayerStats :IStat
{
    public PlayerStats(int intelligence, int strength, int dexterity)
    {
        Intelligence = intelligence;
        Strength = strength;
        Dexterity = dexterity;
        
    }

    public int Intelligence { get; private set; }
    public int Strength { get; private set; }
    public int Dexterity { get; private set; }
  


    public void ModifyIntelligence(int multiplier, int adder)
    {
        Intelligence = Intelligence * multiplier + adder;
    }

    public void ModifyStrength(int multiplier, int adder)
    {
        Strength = Strength * multiplier + adder;
    }

    public void ModifyDexterity(int multiplier, int adder)
    {
        Dexterity = Dexterity * multiplier + adder;
    }
}
