using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class FactoryNPC
{
    public abstract NPC Get(ClassTypes classTypes);
}
