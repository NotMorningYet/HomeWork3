
using UnityEngine;

public class PlayerBootstrap : MonoBehaviour
{
    [SerializeField] Player _player;

  
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            _player.Initialize(new StatProviderAbility(new StatProviderClass(new StatProviderRace(new PlayerStats(10, 10, 10), _player.Race), _player.RPGClass), _player.Ability));
            Debug.Log("Интеллект " + _player.PlayerStat.Intelligence);
            Debug.Log("Сила " + _player.PlayerStat.Strength);
            Debug.Log("Ловкость " + _player.PlayerStat.Dexterity);

        }
 
        
    }
}
