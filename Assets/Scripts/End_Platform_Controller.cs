using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class End_Platform_Controller : MonoBehaviour{
   public GameObject scripter;    
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            scripter.GetComponent<Win_Or_Lose>().player_end = true;
        }
        if(collision.gameObject.CompareTag("Wolf")){
            scripter.GetComponent<Win_Or_Lose>().wolf_end = true;
        }
        if(collision.gameObject.CompareTag("Goat")){
            scripter.GetComponent<Win_Or_Lose>().goat_end = true;
        }
        if(collision.gameObject.CompareTag("Cabbage")){
           scripter.GetComponent<Win_Or_Lose>().cabagge_end = true;
        }
    }
    private void OnCollisionExit(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            scripter.GetComponent<Win_Or_Lose>().player_end = false;
        }
        if(collision.gameObject.CompareTag("Wolf")){
            scripter.GetComponent<Win_Or_Lose>().wolf_end = false;
        }
        if(collision.gameObject.CompareTag("Goat")){
            scripter.GetComponent<Win_Or_Lose>().goat_end = false;
        }
        if(collision.gameObject.CompareTag("Cabbage")){
            scripter.GetComponent<Win_Or_Lose>().cabagge_end = false;
        }
    }
}