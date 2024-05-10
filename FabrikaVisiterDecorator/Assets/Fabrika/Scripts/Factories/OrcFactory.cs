using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class OrcFactory : FactoryNPC
{
    public override NPC Get(ClassTypes classType)
    {
        switch (classType)
        {
            case ClassTypes.Mage:
                return new OrcMageNPC();
            case ClassTypes.Paladin:
                return new OrcPaladinNPC();
            default:
                throw new ArgumentException(nameof(classType));

        }
    }

}
