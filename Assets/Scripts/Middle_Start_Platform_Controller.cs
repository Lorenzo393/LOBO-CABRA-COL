using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle_Start_Platform_Controller : MonoBehaviour
{
    public GameObject scripter;    
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            scripter.GetComponent<Win_Or_Lose>().player_midstart = true;
        }
        if(collision.gameObject.CompareTag("Wolf")){
            scripter.GetComponent<Win_Or_Lose>().wolf_midstart = true;
        }
        if(collision.gameObject.CompareTag("Goat")){
            scripter.GetComponent<Win_Or_Lose>().goat_midstart = true;
        }
        if(collision.gameObject.CompareTag("Cabbage")){
           scripter.GetComponent<Win_Or_Lose>().cabagge_midstart = true;
        }
    }
    private void OnCollisionExit(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            scripter.GetComponent<Win_Or_Lose>().player_midstart = false;
        }
        if(collision.gameObject.CompareTag("Wolf")){
            scripter.GetComponent<Win_Or_Lose>().wolf_midstart = false;
        }
        if(collision.gameObject.CompareTag("Goat")){
            scripter.GetComponent<Win_Or_Lose>().goat_midstart = false;
        }
        if(collision.gameObject.CompareTag("Cabbage")){
            scripter.GetComponent<Win_Or_Lose>().cabagge_midstart = false;
        }
    }
}
