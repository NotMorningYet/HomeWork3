using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private Button _spawn1Button;
    [SerializeField] private Button _spawn2Button;
    [SerializeField] private Button _swithRaceButton;
    private void OnEnable()
    {
     //  _restartBtn.onClick.AddListener(OnSpawn1Click);
    }

    private void OnDisable()
    {
       // _restartBtn.onClick.RemoveListener(OnSpawn2Click);
    }
}
