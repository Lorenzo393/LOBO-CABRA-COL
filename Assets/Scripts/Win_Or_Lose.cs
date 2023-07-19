using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
Win_Lose = 0 -> Nada
Win_Lose = 1 -> Ganaste
Win_Lose = 2 -> Perdiste: Lobo se comio a la Cabra
Win_Lose = 3 -> Perdiste: Cabra se comio a la Col
Win_Lose = 4 -> Perdiste: Tiempo agotado
*/
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
        }
        if(wolf_end == true && goat_end == true && player_end != true && player_midend != true){
            screen_text.text = "EL LOBO SE COMIO A LA CABRA";
            player_movement = false;
        }
        if(goat_end == true && cabbage_end == true && player_end != true && player_midend != true){
            screen_text.text = "LA CABRA SE COMIO LA COL";
            player_movement = false;
        }
        if(wolf_start == true && goat_start == true && player_start != true && player_midstart != true){
            screen_text.text = "EL LOBO SE COMIO A LA CABRA";
            player_movement = false;
        }
        if(goat_start == true && cabbage_start == true && player_start != true && player_midstart != true){
            screen_text.text = "LA CABRA SE COMIO LA COL";
            player_movement = false;
        }
        if(player_drowned == true){
            screen_text.text = "TE AHOGASTE";
            player_movement = false;
        }
        /*
        if(tiempo == x){
            // Tiempo agotado
        }
        */
    }
}
