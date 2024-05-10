
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnerCoin: MonoBehaviour
{
    [SerializeField] private FactoryCoin _factoryCoin;
    [SerializeField] private SpawnGrid _spawnGrid;
    [SerializeField] private float _spawnCooldown;

    private Vector3 _spawnPosition;
    private List<Coin> _spawnedCoins = new List<Coin>();

    private Coroutine _spawn;


    public void StartSpawn()
    {
        StopSpawn();
        _spawn = StartCoroutine(Spawn());
    }


    public void StopSpawn()
    {
        if (_spawn != null)
        {
            StopCoroutine(_spawn);
        }
    }


    private IEnumerator Spawn()
    {
        while (true)
        {
            if (_spawnGrid.FreePlacesForCoins != 0)
            {
                Coin coin = _factoryCoin.Get((CoinTypes)UnityEngine.Random.Range(0, Enum.GetValues(typeof(CoinTypes)).Length));
                _spawnPosition = _spawnGrid.GetFreeSpawnPosition();

                Coin spawnedCoin = Instantiate(coin, _spawnPosition, Quaternion.identity);
                _spawnedCoins.Add(spawnedCoin);
            }
            
            yield return new WaitForSeconds(_spawnCooldown);

        }
    }

}
