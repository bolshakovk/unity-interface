using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject optionsMenu;
    public Button optionButton;
    // Start is called before the first frame update
    void Start()
    {
        optionButton.onClick.AddListener(SetMenuVisible);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SetMenuVisible();
        }
    }
    public void SetMenuVisible()
    {
        optionsMenu.gameObject.SetActive(!optionsMenu.gameObject.activeSelf);
    }
}
