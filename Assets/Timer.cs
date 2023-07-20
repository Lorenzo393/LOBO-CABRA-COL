using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Text time_text;
    public float time = 100f;
    void FixedUpdate(){
        time -= Time.deltaTime;
        time_text.text = "TIEMPO: " + time.ToString("f0");
    }
}
