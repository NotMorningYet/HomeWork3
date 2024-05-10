using System;
using UnityEngine;

namespace Assets.Visitor
{
    public class Weight : IDisposable
    {
        public bool IsWeightEdgeReached { get; private set; }

        private int weightEdge = 30;
        private int currentWeight => _enemyVisitorWeight.Weight;
        private IEnemyDeathNotifier _enemyDeathNotifier;
        private Spawner _spawner;
        private EnemyVisitorWeight _enemyVisitorWeight;

        private const SByte ADD = 1;
        private const SByte REMOVE = -1;

        public Weight(IEnemyDeathNotifier enemyDeathNotifier, Spawner spawner)
        {
            _enemyDeathNotifier = enemyDeathNotifier;
            _spawner = spawner;
            _enemyDeathNotifier.DeathNotified += OnEnenmyKilled;
            _spawner.Spawned += OnEnemySpawned;

            _enemyVisitorWeight = new EnemyVisitorWeight();
            IsWeightEdgeReached = false;

        }

        public void Dispose()
        {
            _enemyDeathNotifier.DeathNotified -= OnEnenmyKilled;
            _spawner.Spawned -= OnEnemySpawned;

        }

        private void OnEnenmyKilled(Enemy enemy)
        {

            _enemyVisitorWeight.Visit(enemy, REMOVE);

            Debug.Log("Текущий общий вес " + currentWeight);

            if (currentWeight < weightEdge) IsWeightEdgeReached = false;

        }
        private void OnEnemySpawned(Enemy enemy)
        {
            _enemyVisitorWeight.Visit(enemy, ADD);

            Debug.Log("Текущий общий вес " + currentWeight);

            if (currentWeight >= weightEdge) IsWeightEdgeReached = true;

        }


        private class EnemyVisitorWeight : IEnemyVisitorWeight
        {
            public int Weight { get; private set; }

            public void Visit(Elf elf, sbyte addRemove) => Weight = Weight + addRemove * 7;

            public void Visit(Human human, sbyte addRemove) => Weight = Weight + addRemove * 5;

            public void Visit(Ork ork, sbyte addRemove) => Weight = Weight + addRemove * 13;

            public void Visit(Robot robot, sbyte addRemove) => Weight = Weight + addRemove * 9;

            public void Visit(Enemy enemy, sbyte addRemove) => Visit((dynamic)enemy, addRemove);
        }


    }
}
