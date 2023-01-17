using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransCylinder : MonoBehaviour
{
    public GameObject curGameObject;
    private Material curMat;
    
    public ToggleController toggleController;

    // Value changed transparent
    public float alpha = 0.5f;

    // Start is called before the first frame update
    void Start()
    {   
        curGameObject = gameObject;
        // // Get the Renderer component from the new cylinder
        var renderer = curGameObject.GetComponent<Renderer>();

        // Call SetColor using the shader property name "_Color" and setting the color to yellow
        renderer.material.SetColor("_Color", Color.yellow);
        
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
        if(toggleController._toggles[2].isOn == true)
        {
            ChangeAlpha(curMat, slider.value);
        }
    }
}
