using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this script manages and calculates the combostates of the music for the player, according to the entered values in the inspector
public class ComboManagerScript : MonoBehaviour {

    private Image comboTimerImage;
    private float timer;

    //individual lengths of combowindows
    public float comboTimerLength;
    public float comboWindowLength1;
    public float comboWindowLength2;

    public int comboState;

	// Use this for initialization
	void Start () {

        timer = 0.0f;
        comboState = 0;
	}
	
	// Update is called once per frame
	void Update () {

        //add delta to timer and check if 1 period of combo is over
        timer += Time.deltaTime;
        timer %= comboTimerLength;

        //check in which combophase we are
        //green means strong, orange means medium, red means no combo
        if ((timer < (comboWindowLength2 / 2)) || (timer > comboTimerLength - (comboWindowLength2 / 2))) comboState = 2;
        else if ((timer < (comboWindowLength1 / 2)) || (timer > comboTimerLength - (comboWindowLength1 / 2))) comboState = 1;
        else comboState = 0;
       
    }
}
