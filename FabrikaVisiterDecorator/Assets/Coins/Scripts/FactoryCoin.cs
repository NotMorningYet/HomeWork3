using System;
using UnityEngine;


public class FactoryCoin : MonoBehaviour
{
    [SerializeField] private GoldCoin _goldCoinPrefab;
    [SerializeField] private SilverCoin _silverCoinPrefab;
    [SerializeField] private CopperCoin _copperCoinPrefab;
    public Coin Get(CoinTypes coinType)
    {
        switch (coinType)
        {
            case CoinTypes.Gold:
                return _goldCoinPrefab;
            case CoinTypes.Silver:
                return _silverCoinPrefab;
            case CoinTypes.Copper:
                return _copperCoinPrefab;
            default:
                throw new ArgumentException(nameof(coinType));
        }
    }
}
