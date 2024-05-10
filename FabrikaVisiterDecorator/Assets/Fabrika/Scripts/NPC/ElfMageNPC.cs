using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfMageNPC : NPC, ICastSpell
{
    public void CastSpell()
    {
        Debug.Log("Люмос");
    }

    public void RaceFeatureSpell()
    {
        Debug.Log("Да пребудет с тобой свет!");
    }

    public override void Init()
    {
        Debug.Log("Я - эльф");
        CastSpell();
        RaceFeatureSpell();

    }
}
