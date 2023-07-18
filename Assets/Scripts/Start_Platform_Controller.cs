using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Platform_Controller : MonoBehaviour
{
    public GameObject scripter;    
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            scripter.GetComponent<Win_Or_Lose>().player_start = true;
        }
        if(collision.gameObject.CompareTag("Wolf")){
            scripter.GetComponent<Win_Or_Lose>().wolf_start = true;
        }
        if(collision.gameObject.CompareTag("Goat")){
            scripter.GetComponent<Win_Or_Lose>().goat_start = true;
        }
        if(collision.gameObject.CompareTag("Cabbage")){
           scripter.GetComponent<Win_Or_Lose>().cabagge_start = true;
        }
    }
    private void OnCollisionExit(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            scripter.GetComponent<Win_Or_Lose>().player_start = false;
        }
        if(collision.gameObject.CompareTag("Wolf")){
            scripter.GetComponent<Win_Or_Lose>().wolf_start = false;
        }
        if(collision.gameObject.CompareTag("Goat")){
            scripter.GetComponent<Win_Or_Lose>().goat_start = false;
        }
        if(collision.gameObject.CompareTag("Cabbage")){
            scripter.GetComponent<Win_Or_Lose>().cabagge_start = false;
        }
    }
}
