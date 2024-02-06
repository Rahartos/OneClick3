using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayClicks : MonoBehaviour
{
    // Start is called before the first frame update
    public int click = 0;
    public Text displayText;
    void Update(){
        displayText.text = "Clicks: " + click;

        if(Input.GetMouseButtonDown(0)){
            Debug.Log("Pressed left-click.");
            click++;

        }
            
    }

}
