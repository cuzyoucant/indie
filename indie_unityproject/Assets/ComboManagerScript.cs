using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboManagerScript : MonoBehaviour {

    private Image comboTimerImage;
    private float timer;

    //individual lengths of combowindows
    public float comboTimerLength;
    public float comboWindowLength1;
    public float comboWindowLength2;

	// Use this for initialization
	void Start () {

        //get comboImage and check if null
        comboTimerImage = GameObject.Find("ComboTimerDisplay").GetComponent<Image>();
        if (comboTimerImage == null) Debug.LogError("comboTimerImage is null");

        timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

        //add delta to timer and check if 1 period of combo is over
        timer += Time.deltaTime;
        timer %= comboTimerLength;

        //check in which combophase we are
        //green means strong, orange means medium, red means no combo
        if ((timer < (comboWindowLength2 / 2)) || (timer > comboTimerLength - (comboWindowLength2 / 2))) comboTimerImage.color = new Color32(0, 255, 0, 100);
        else if ((timer < (comboWindowLength1 / 2)) || (timer > comboTimerLength - (comboWindowLength1 / 2))) comboTimerImage.color = new Color32(255, 165, 0, 100);
        else comboTimerImage.color = new Color32(255, 0, 0, 100);
       
    }
}
