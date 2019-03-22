using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float time;
    float best = -1f;
    Text text;
    bool pause;
    // Start is called before the first frame update
    void Start()
    {
        Reset();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause)
        {
            time += Time.deltaTime;
            if (best > 0){
                text.text = best.ToString() + "        " + time.ToString();
            }else{
                text.text = "N/A        " + time.ToString();
            }
        }
    }

    public void Reset()
    {
        time = 0f;
        pause = false;
    }

    public void Stop()
    {
        pause = true;
    }

    public void Win()
    {
        pause = true;
        if (best < 0f || time < best)
            best = time;
    }
}
