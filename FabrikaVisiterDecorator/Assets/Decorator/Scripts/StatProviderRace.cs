
using UnityEngine.Rendering.Universal;

public class StatProviderRace : IStat
{
    public int Intelligence { get; private set; }
    public int Dexterity { get; private set; }
    public int Strength { get; private set; }


    private IStat _stat;
    private int _multiplierIntelligence;
    private int _adderIntelligence;
    private int _multiplierStrength;
    private int _adderStrength;
    private int _multiplierDexterity;
    private int _adderDexterity;

    public StatProviderRace(IStat stat, RaceType race)
    {
        Intelligence = stat.Intelligence;
        Strength = stat.Strength;
        Dexterity = stat.Dexterity;
        
        _stat = stat;

        SetModifiers(race);
        ModifyIntelligence(_multiplierIntelligence, _adderIntelligence);
        ModifyStrength(_multiplierStrength, _adderStrength);
        ModifyDexterity(_multiplierDexterity, _adderDexterity);
        

}

public void SetModifiers(RaceType race)
{
switch (race)
{
case RaceType.Human:
   _multiplierIntelligence = 1;
   _adderIntelligence = 0; 

   _multiplierStrength = 1;
   _adderStrength = 0;

   _multiplierDexterity = 1;
   _adderDexterity = 0;

   break;

case RaceType.Elf:
   _multiplierIntelligence = 1;
   _adderIntelligence = 2;

   _multiplierStrength = 1;
   _adderStrength = -2;

   _multiplierDexterity = 1;
   _adderDexterity = 3;
   break;

case RaceType.Orc:
   _multiplierIntelligence = 1;
   _adderIntelligence = -2;


   _multiplierStrength = 1;
   _adderStrength = 5;

   _multiplierDexterity = 1;
   _adderDexterity = -4;
   break;

}

}
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
