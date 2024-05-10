using System.Collections.Generic;
using UnityEngine;


public class SpawnGrid :MonoBehaviour
{    
    [SerializeField] private int _gridSize;

    public int FreePlacesForCoins { get; private set; }

    private Vector3 _spawnPosition;
    private int _xPosition;
    private int _zPosition;

    private List<GridCoinPosition> _gridFreePositions;
    private GridCoinPosition _selectedGridPosition;
    
    public void Initialize()
    {
        FreePlacesForCoins = 0;
        _gridFreePositions = new List<GridCoinPosition>();
       for (int x = 0; x <_gridSize; x +=1) 
        {
            for (int z = 0; z < _gridSize; z += 1)
            {
                _gridFreePositions.Add(new GridCoinPosition(x, z));
                FreePlacesForCoins = FreePlacesForCoins + 1;
            }
        }
    }

    public Vector3 GetFreeSpawnPosition()
    {
        int index = (int)Mathf.Round(UnityEngine.Random.Range(0, FreePlacesForCoins));
        _selectedGridPosition = _gridFreePositions[index];

        _xPosition = _selectedGridPosition.XPos;
        _zPosition = _selectedGridPosition.ZPos;

        _spawnPosition = new Vector3(_xPosition, 0, _zPosition);

        _gridFreePositions.RemoveAt(index);
        FreePlacesForCoins = FreePlacesForCoins - 1;
             
        return _spawnPosition;
    }

    public void AddFreePositionGrid(int xPos, int zPos)
    {
        _gridFreePositions.Add(new GridCoinPosition(xPos, zPos));
        FreePlacesForCoins = FreePlacesForCoins + 1;
    }
}
