using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcMageNPC : NPC, ICastSpell
{
    public void CastSpell()
    {
        Debug.Log("����� �������");
    }

    public void RaceFeatureSpell()
    {
        Debug.Log("������ - ����!");
    }

    public override void Init()
    {
        Debug.Log("� - ���");
        CastSpell();
        RaceFeatureSpell();
    }
}
