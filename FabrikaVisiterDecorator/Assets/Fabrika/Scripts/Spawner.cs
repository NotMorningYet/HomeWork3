using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental.FileFormat;
using UnityEngine;
using UnityEngine.UI;


public class Spawner : MonoBehaviour
{

    public Button _spawnButton;
    public RaceTypes _raceType;
    private ClassTypes _classType;
    public ElfFactory _elfFactoryNPC;
    public OrcFactory _orcFactoryNPC;
    public FactoryNPC _currentFactoryNPC;

    public List<NPC> SpawnedNPCs;
    private NPC _npc;

    public void Initiallize(RaceTypes raceType, ElfFactory elfFactory, OrcFactory orcFctory, FactoryNPC currentFactory)
    {
        _raceType = raceType;
        _elfFactoryNPC = elfFactory;
        _orcFactoryNPC = orcFctory;
        _currentFactoryNPC = currentFactory;
    }
    private void SpawnPerson()
    {
        SelectClassType();
        _npc = _currentFactoryNPC.Get(_classType);
        _npc.Init();
        SpawnedNPCs.Add(_npc);

    }

    private void OnEnable()
    {
        _spawnButton.onClick.AddListener(SpawnPerson);
    }

    private void OnDisable()
    {
        _spawnButton.onClick.RemoveListener(SpawnPerson);
    }

    private void SelectClassType()
    {
        _classType = (ClassTypes)UnityEngine.Random.Range(0, Enum.GetValues(typeof(ClassTypes)).Length);
    }

    public void SwitchRaces()
    {
        switch (_raceType)
        {
            case RaceTypes.Elf:
                {
                    _raceType = RaceTypes.Orc;
                    _currentFactoryNPC = _orcFactoryNPC;
                    break;
                }
            case RaceTypes.Orc:
                {
                    _raceType = RaceTypes.Elf;
                    _currentFactoryNPC = _elfFactoryNPC;
                    break;
                }

        }
    }
}