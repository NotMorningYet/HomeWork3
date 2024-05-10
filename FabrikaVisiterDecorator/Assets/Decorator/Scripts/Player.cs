
using UnityEngine;

public class Player : MonoBehaviour
{
    public RaceType Race;
    public RPGClassType RPGClass;
    public AbilityType Ability;
    public PlayerStats PlayerStat { get; private set; }

    private IStat _stat;

    public void Initialize(IStat stat)
    {

        _stat = stat;
        PlayerStat = new PlayerStats(_stat.Intelligence, _stat.Strength, _stat.Dexterity);
        
   
    }

}
