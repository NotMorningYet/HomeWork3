
public interface IStat 
{
    int Intelligence { get; }
    int Strength { get; }
    int Dexterity { get; }


    void ModifyIntelligence(int multiplier, int adder);
    void ModifyStrength(int multiplier, int adder);
    void ModifyDexterity(int multiplier, int adder);
 

}
