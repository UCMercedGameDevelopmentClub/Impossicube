using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        if (Input.GetKey("1"))
        {
            SceneManager.LoadScene("level0");
        }

        if (Input.GetKey("2"))
        {
            SceneManager.LoadScene("level9");
        }
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
