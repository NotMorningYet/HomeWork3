using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfFactory : FactoryNPC
{
    public override NPC Get(ClassTypes classType)
    {
        switch(classType)
        {
            case ClassTypes.Mage:
                return new ElfMageNPC();
            case ClassTypes.Paladin: 
                return new ElfPaladinNPC();
            default:
                throw new ArgumentException(nameof(classType));

        }
    }


}
