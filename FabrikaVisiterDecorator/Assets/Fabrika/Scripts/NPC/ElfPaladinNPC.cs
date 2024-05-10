using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfPaladinNPC : NPC, IPaladin
{
    public void Attack()
    {
        Debug.Log("� �����!");
    }

    public void RaceFeatureAttack()
    {
        Debug.Log("�� ���������!");
    }

    public override void Init()
    {
        Debug.Log("� - ����");
        Attack();
        RaceFeatureAttack();
    }
}
