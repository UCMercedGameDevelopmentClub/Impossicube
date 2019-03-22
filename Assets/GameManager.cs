using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetTimer()
    {
        timer.Reset();
    }

    public void StopTimer()
    {
        timer.Stop();
    }

    public void Win()
    {
        timer.Win();
    }
}
