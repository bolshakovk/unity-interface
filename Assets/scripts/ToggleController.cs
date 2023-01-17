using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleController : MonoBehaviour
{

    public Toggle[] _toggles;
    Material curMat;
    public GameObject[] _gameObjects;
    public Toggle mainCheckerToggle;
    public Toggle mainHiderToggle;
    // Start is called before the first frame update
    void Start()
    {
        CheckAllTogglesOff();
    }

    // бизнес логика включения отключения туглов
    public void SwitcherToggles()
    {
        if(mainCheckerToggle.isOn)
        {
            CheckAllTogglesOn();
        }
        else
        {
            CheckAllTogglesOff();
        }
    }
    // business logic hide or show toggles
    public void HiderObjects()
    {
        if(mainHiderToggle.isOn)
        {
            Hider();
        }
        else
        {
            Shower();
        }
    }
    public void ChangeMaterial()
    {

    }
    private void CheckAllTogglesOff()
    {
        for(int i = 0; i < _toggles.Length; i++)
        {
            _toggles[i].isOn = false;
        }
    }
    public void CheckAllTogglesOn()
    {
        for(int i = 0; i < _toggles.Length; i++)
        {
            _toggles[i].isOn = true;
        }
    }

    private void Hider()
    {
        for(int i =0; i < _toggles.Length; i++)
        {
            if(_toggles[i].isOn == true)
            {
                _gameObjects[i].SetActive(false);
            }
        }
    }
    private void Shower()
    {
        for(int i =0; i < _toggles.Length; i++)
        {
            _gameObjects[i].SetActive(true);
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
