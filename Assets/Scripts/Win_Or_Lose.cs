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










    public Text wltext;
    private int wl = 0;
    public void Win_Lose(int i){
        wl = i;

        if(wl == 1){
            wltext.text = "Ganaste";
        }

    }
}
