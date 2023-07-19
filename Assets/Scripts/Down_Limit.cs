using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down_Limit : MonoBehaviour
{
    public GameObject scripter;
    public GameObject wolf;
    public GameObject goat;
    public GameObject cabbage;
    private void OnTriggerEnter(Collider collider){
        if(collider.gameObject.CompareTag("Player")){
            scripter.GetComponent<Win_Or_Lose>().player_drowned = true;
        }
        if(collider.gameObject.CompareTag("Wolf")){
            Instantiate(wolf, new Vector3(-6 , 1 , 3),Quaternion.identity);
        }
        if(collider.gameObject.CompareTag("Goat")){
            Instantiate(wolf, new Vector3(-6 , 1 , 0),Quaternion.identity);
        }
        if(collider.gameObject.CompareTag("Cabbage")){
            Instantiate(wolf, new Vector3(-6 , 1 , -3),Quaternion.identity);
        }
    }
}