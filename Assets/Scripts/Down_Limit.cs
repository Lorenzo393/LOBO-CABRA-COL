using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down_Limit : MonoBehaviour
{
    public GameObject player;
    public GameObject wolf;
    public GameObject goat;
    public GameObject cabbage;

    private Rigidbody rb_player;
    private Rigidbody rb_wolf;
    private Rigidbody rb_goat;
    private Rigidbody rb_cabbage;
    
     void start(){
        rb_player = player.GetComponent<Rigidbody> ();
        rb_wolf = wolf.GetComponent<Rigidbody> ();
        rb_goat = goat.GetComponent<Rigidbody> ();
        rb_cabbage = cabbage.GetComponent<Rigidbody> ();
    }
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
