using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this scipt changes the imagecolor of the debugimage according to the combostate, for better testing/debugging without music
public class ComboTimerDisplayScript : MonoBehaviour {

    private ComboManagerScript cms;
    private Image img;

    private int oldComboState;

	// Use this for initialization
	void Start () {
        cms = GameObject.Find("ComboManager").GetComponent<ComboManagerScript>();
        if (cms == null) Debug.LogError("combomanagerscript is null");

        img = transform.GetComponent<Image>();
        if (img == null) Debug.LogError("comboimage is null");

        oldComboState = 0;
	}
	
	// Update is called once per frame
	void Update () {

        //if combostate changed, change image color
		if(cms.comboState != oldComboState)
        {
            oldComboState = cms.comboState;

            switch (oldComboState)
            {
                case 0:
                    //set image to color red
                    img.color = new Color32(255, 0, 0, 100);
                    break;

                case 1:
                    //set image to color orange
                    img.color = new Color32(255, 165, 0, 100);
                    break;

                case 2:
                    //set image to color green
                    img.color = new Color32(0, 255, 0, 100);
                    break;

                default:
                    Debug.LogError("combostate unknown");
                    break;
            }
        }
	}
}
