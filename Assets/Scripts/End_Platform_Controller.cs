using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Platform_Controller : MonoBehaviour
{   
    public bool Wolf_End = false;
    public bool Goat_End = false;
    public bool Cabbage_End = false;
    public bool Player_End = false;
    void Start(){
        GameObject scripter = GameObject.Find("Scripter");
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            Player_End = true;
        }
        if(collision.gameObject.CompareTag("Wolf")){
            Wolf_End = true;
        }
        if(collision.gameObject.CompareTag("Goat")){
            Goat_End = true;
        }
        if(collision.gameObject.CompareTag("Cabbage")){
            Cabbage_End = true;
        }
    }
    private void OnCollisionExit(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            Player_End = false;
        }
        if(collision.gameObject.CompareTag("Wolf")){
            Wolf_End = false;
        }
        if(collision.gameObject.CompareTag("Goat")){
            Goat_End = false;
        }
        if(collision.gameObject.CompareTag("Cabbage")){
            Cabbage_End = false;
        }
    }
}

  /*
        if(collision.gameObject.CompareTag("Wolf") && collision.gameObject.CompareTag("Cabbage") && collision.gameObject.CompareTag("Goat")){
            GameObject scripter = GameObject.Find("Scripter");
            scripter.GetComponent<Win_Or_Lose>().Win_Lose(1);
        }
        */
        /*
        if(collision.gameObject.CompareTag("Wolf") && collision.gameObject.CompareTag("Goat")){
            GameObject scripter = GameObject.Find("Scripter");
            scripter.GetComponent<Win_Or_Lose>().Win_Lose(2);
        }
        
        if(collision.gameObject.CompareTag("Goat") && collision.gameObject.CompareTag("Cabbage")){
            GameObject scripter = GameObject.Find("Scripter");
            scripter.GetComponent<Win_Or_Lose>().Win_Lose(3);
        }
        */
