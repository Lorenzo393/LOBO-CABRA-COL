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
    public bool player_end;         // End
    public bool wolf_end;
    public bool goat_end;
    public bool cabagge_end;        // End
    public bool player_midend;      // MidEnd
    public bool wolf_midend;
    public bool goat_midend;
    public bool cabagge_midend;     // MidEnd
    public bool player_midstart;    // MidStart
    public bool wolf_midstart;
    public bool goat_midstart;
    public bool cabagge_midstart;   // MidStart
    public bool player_start;       // Start
    public bool wolf_start;
    public bool goat_start;
    public bool cabagge_start;      // Start

    public Text wltext;
    private int wl = 0;
    public void Win_Lose(int i){
        wl = i;

        if(wl == 1){
            wltext.text = "Ganaste";
        }

    }
}
