using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableDIsable : MonoBehaviour
{
    public GameObject Room;
    public bool isEnable = true;

    public Text buttonText;



    public void ButtonClicked()
    {
        isEnable = !isEnable;
        Room.SetActive(isEnable);

        if (isEnable == true)
        {
            buttonText.text = "Object Enabled";

        }
        else
        {
            buttonText.text = "Object Disabled";

        }



    }

}
