using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcMageNPC : NPC, ICastSpell
{
    public void CastSpell()
    {
        Debug.Log("Авада Кедавра");
    }

    public void RaceFeatureSpell()
    {
        Debug.Log("Мордор - сила!");
    }

    public override void Init()
    {
        Debug.Log("Я - орк");
        CastSpell();
        RaceFeatureSpell();
    }
}
