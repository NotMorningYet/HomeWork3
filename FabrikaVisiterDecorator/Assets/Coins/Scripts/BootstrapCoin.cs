
using UnityEngine;

public class BootstrapCoin : MonoBehaviour
{
    [SerializeField] private SpawnerCoin _spawner;
    [SerializeField] private SpawnGrid _spawnGrid;
    private void Awake()
    {
        _spawnGrid.Initialize();
        _spawner.StartSpawn();
        
    }
}
