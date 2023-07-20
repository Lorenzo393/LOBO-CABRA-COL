using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class Win_Or_Lose : MonoBehaviour
{
    public bool player_end;             // End
    public bool wolf_end;
    public bool goat_end;
    public bool cabbage_end;            // End
    public bool player_midend;          // MidEnd
    public bool wolf_midend;
    public bool goat_midend;
    public bool cabbage_midend;         // MidEnd
    public bool player_midstart;        // MidStart
    public bool wolf_midstart;
    public bool goat_midstart;
    public bool cabbage_midstart;       // MidStart
    public bool player_start;           // Start
    public bool wolf_start;
    public bool goat_start;
    public bool cabbage_start;          // Start
    public bool player_drowned;         // Player
    public bool player_movement = true; // Player
    public Text screen_text;
    void FixedUpdate(){
        if(wolf_end == true && goat_end == true && cabbage_end == true){
            screen_text.text = "GANASTE";
            gameObject.SetActive(false);
        }
        if(wolf_end == true && goat_end == true && player_end != true && player_midend != true){
            screen_text.text = "EL LOBO SE COMIO A LA CABRA";
            player_movement = false;
            gameObject.SetActive(false);
        }
        if(goat_end == true && cabbage_end == true && player_end != true && player_midend != true){
            screen_text.text = "LA CABRA SE COMIO LA COL";
            player_movement = false;
            gameObject.SetActive(false);
        }
        if(wolf_start == true && goat_start == true && player_start != true && player_midstart != true){
            screen_text.text = "EL LOBO SE COMIO A LA CABRA";
            player_movement = false;
            gameObject.SetActive(false);
        }
        if(goat_start == true && cabbage_start == true && player_start != true && player_midstart != true){
            screen_text.text = "LA CABRA SE COMIO LA COL";
            player_movement = false;
            gameObject.SetActive(false);
        }
        if(player_drowned == true){
            screen_text.text = "TE AHOGASTE";
            player_movement = false;
            gameObject.SetActive(false);
        }
        if(gameObject.GetComponent<Timer>().time <= 0){
            screen_text.text = "SE ACABO EL TIEMPO";
            player_movement = false;
            gameObject.SetActive(false);
        }
    }
}
