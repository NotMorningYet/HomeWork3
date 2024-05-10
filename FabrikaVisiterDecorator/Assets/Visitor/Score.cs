using System;
using UnityEngine;

namespace Assets.Visitor
{
    public class Score: IDisposable
    {
        public int Value => _enemyVisitor.Score;

        private IEnemyDeathNotifier _enemyDeathNotifier;
        private EnemyVisitor _enemyVisitor;

        public Score(IEnemyDeathNotifier enemyDeathNotifier)
        {
            _enemyDeathNotifier = enemyDeathNotifier;
            _enemyDeathNotifier.DeathNotified += OnEnenmyKilled;

            _enemyVisitor = new EnemyVisitor();
        }

        public void OnEnenmyKilled(Enemy enemy)
        {
            _enemyVisitor.Visit(enemy);
            Debug.Log("C���: " + Value);
        }

        public void Dispose()
        {
            _enemyDeathNotifier.DeathNotified -= OnEnenmyKilled;
        }

        private class EnemyVisitor : IEnemyVisitor
        {
            public int Score { get; private set; }

            public void Visit(Elf elf) => Score += 10;

            public void Visit(Human human) => Score += 5;

            public void Visit(Ork ork) => Score += 20;

            public void Visit(Robot robot) => Score += 15;

            public void Visit(Enemy enemy) => Visit((dynamic) enemy);
        }
    }
}

