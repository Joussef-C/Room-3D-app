using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyColour : MonoBehaviour
{
    public FlexibleColorPicker fcp;
    public Material material;

    // Update is called once per frame
    private void Update()
    {

        material.color = fcp.color;
        
    }
}
