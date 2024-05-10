using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] Button _spawner1Button;
    [SerializeField] Button _spawner2Button;
    [SerializeField] Button _raceSwitcherButton;

    [SerializeField] Spawner _spawner1;
    [SerializeField] Spawner _spawner2;

    private ElfFactory _elfFactory;
    private OrcFactory _orcFactory;

    private void Awake()
    {
          
        _elfFactory = new ElfFactory();
        _orcFactory = new OrcFactory();

        _spawner1.Initiallize(RaceTypes.Elf, _elfFactory, _orcFactory, _elfFactory);
        _spawner2.Initiallize(RaceTypes.Orc, _elfFactory, _orcFactory, _orcFactory);

        _spawner1.SpawnedNPCs = new List<NPC>();
        _spawner2.SpawnedNPCs = new List<NPC>();

    }

    private void OnEnable()
    {
        _raceSwitcherButton.onClick.AddListener(SwitchRaces);
    }

    private void OnDisable()
    {
        _raceSwitcherButton.onClick.RemoveListener(SwitchRaces);
    }
    private void SwitchRaces()
    {
        _spawner1.SwitchRaces();
        _spawner2.SwitchRaces();
    }
}
