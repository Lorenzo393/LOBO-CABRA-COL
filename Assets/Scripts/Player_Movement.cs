using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public GameObject scripter;
    private Rigidbody rb;
    public float speed = 10f;
    void Start(){
        rb = GetComponent<Rigidbody> ();
    }
    void FixedUpdate(){
        if(scripter.GetComponent<Win_Or_Lose>().player_movement == true){
            float move_h = Input.GetAxis("Horizontal");
            float move_v = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(move_h , 0.0f , move_v);
            rb.AddForce(movement*speed);
        }
    }
}
