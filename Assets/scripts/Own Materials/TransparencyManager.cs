using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransparencyManager : MonoBehaviour
{
    private MeshRenderer r;
    public GameObject curGameObject;
    private Material curMat;
    public ToggleController toggleController;
    
    
    // Value changed transparent
    public float alpha = 0.5f;

    // Start is called before the first frame update
    void Start()
    {   
        curGameObject = gameObject;
        // // Get the Renderer component from the new cube
        var cubeRenderer = curGameObject.GetComponent<Renderer>();

        // Call SetColor using the shader property name "_Color" and setting the color to red
        cubeRenderer.material.SetColor("_Color", Color.red);
        
        curMat = curGameObject.GetComponent<Renderer>().material; 
        MaterialExtensions.ToFadeMode(curMat);    
    }

    // Update is called once per frame
    void Update()
    {   
    }
    public void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);
    }
    // Change transparent by alpha
    public void ChangeAlphaOnValueChanged(Slider slider)
    {
        if(toggleController._toggles[0].isOn == true)
        {
            ChangeAlpha(curMat, slider.value);
        }
    }
}