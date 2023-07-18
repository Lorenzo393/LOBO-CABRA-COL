using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down_Limit : MonoBehaviour
{
    public GameObject player;
    public GameObject wolf;
    public GameObject goat;
    public GameObject cabbage;
    
    public Rigidbody rb_player;
    public Rigidbody rb_wolf;
    public Rigidbody rb_goat;
    public Rigidbody rb_cabbage;
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            rb_player.velocity = Vector3.zero;
            rb_player.angularVelocity = Vector3.zero;
            player.transform.position = new Vector3(-8 , 1 , 0);
        }
        if(collision.gameObject.CompareTag("Wolf")){
            rb_wolf.velocity = Vector3.zero;
            rb_wolf.angularVelocity = Vector3.zero;
            wolf.transform.position = new Vector3(-6 , 1 , 3);
        }
        if(collision.gameObject.CompareTag("Goat")){
            rb_goat.velocity = Vector3.zero;
            rb_goat.angularVelocity = Vector3.zero;
            goat.transform.position = new Vector3(-6 , 1 , 0);
        }
        if(collision.gameObject.CompareTag("Cabbage")){
            rb_cabbage.velocity = Vector3.zero;
            rb_cabbage.angularVelocity = Vector3.zero;
            cabbage.transform.position = new Vector3(-6 , 1 , -3);
        }
    }
}