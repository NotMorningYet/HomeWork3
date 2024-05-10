using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcPaladinNPC : NPC
{
    public void Attack()
    {
        Debug.Log("В атаку!");
    }

    public void RaceFeatureAttack()
    {
        Debug.Log("За Мордор!!");
    }

    public override void Init()
    {
        Debug.Log("Я - орк");
        Attack();
        RaceFeatureAttack();
    }

}
