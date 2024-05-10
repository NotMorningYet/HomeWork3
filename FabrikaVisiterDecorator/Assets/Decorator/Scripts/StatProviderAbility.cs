
public class StatProviderAbility : IStat
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
    public StatProviderAbility(IStat stat, AbilityType ability)
    {
        Intelligence = stat.Intelligence;
        Strength = stat.Strength;
        Dexterity = stat.Dexterity;
     
        _stat = stat;

        SetModifiers(ability);

        ModifyIntelligence(_multiplierIntelligence, _adderIntelligence);
        ModifyStrength(_multiplierStrength, _adderStrength);
        ModifyDexterity(_multiplierDexterity, _adderDexterity);

    }


    public void SetModifiers(AbilityType ability)
    {
        switch (ability)
        {
            case AbilityType.Superbrain:
                _multiplierIntelligence = 1;
                _adderIntelligence = 8;

                _multiplierStrength = 1;
                _adderStrength = 0;

                _multiplierDexterity = 1;
                _adderDexterity = 0;

                break;

            case AbilityType.Flexing:
                _multiplierIntelligence = 1;
                _adderIntelligence = 0;

                _multiplierStrength = 1;
                _adderStrength = 0;

                _multiplierDexterity = 1;
                _adderDexterity = 6;
                break;

            case AbilityType.Powerchord:
                _multiplierIntelligence = 1;
                _adderIntelligence = 0;


                _multiplierStrength = 1;
                _adderStrength = 8;

                _multiplierDexterity = 1;
                _adderDexterity = 0;
                break;

            case AbilityType.None:
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
