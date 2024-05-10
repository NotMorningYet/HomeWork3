using System;

namespace Assets.Visitor
{
    public interface IEnemyVisitorWeight
    {
        void Visit(Enemy enemy, sbyte addRemove);
        void Visit(Elf elf, sbyte addRemove);
        void Visit(Human human, sbyte addRemove);
        void Visit(Ork ork, sbyte addRemove);
        void Visit(Robot robot, sbyte addRemove);
    }
}
