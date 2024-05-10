
public class StatProviderClass : IStat
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
    public StatProviderClass(IStat stat, RPGClassType rpgClass)
    {
        Intelligence = stat.Intelligence;
        Strength = stat.Strength;
        Dexterity = stat.Dexterity;
      
        _stat = stat;

        SetModifiers(rpgClass);
     
        ModifyIntelligence(_multiplierIntelligence, _adderIntelligence);
        ModifyStrength(_multiplierStrength, _adderStrength);
        ModifyDexterity(_multiplierDexterity, _adderDexterity);
    }


    public void SetModifiers(RPGClassType rpgClass)
    {
        switch (rpgClass)
        {
            case RPGClassType.Mage:
                _multiplierIntelligence = 2;
                _adderIntelligence = 0;

                _multiplierStrength = 1;
                _adderStrength = -4;

                _multiplierDexterity = 1;
                _adderDexterity = -2;

                break;

            case RPGClassType.Warrior:
                _multiplierIntelligence = 1;
                _adderIntelligence = -2;

                _multiplierStrength = 2;
                _adderStrength = 0;

                _multiplierDexterity = 1;
                _adderDexterity = 2;
                break;

            case RPGClassType.Thief:
                _multiplierIntelligence = 1;
                _adderIntelligence = 1;


                _multiplierStrength = 1;
                _adderStrength = -3;

                _multiplierDexterity = 2;
                _adderDexterity = 0;
                break;

            case RPGClassType.None:
                _multiplierIntelligence = 1;
                _adderIntelligence = 0;


                _multiplierStrength = 1;
                _adderStrength = 0;

                _multiplierDexterity = 1;
                _adderDexterity = 0;
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
