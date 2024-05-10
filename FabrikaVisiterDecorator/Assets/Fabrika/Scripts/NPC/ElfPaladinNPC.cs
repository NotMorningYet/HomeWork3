using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfPaladinNPC : NPC, IPaladin
{
    public void Attack()
    {
        Debug.Log("В атаку!");
    }

    public void RaceFeatureAttack()
    {
        Debug.Log("За Лотлориен!");
    }

    public override void Init()
    {
        Debug.Log("Я - эльф");
        Attack();
        RaceFeatureAttack();
    }
}
