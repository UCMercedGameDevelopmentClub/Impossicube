using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishCube : Cube
{
    protected static Text screenText;
    // Start is called before the first frame update
    void Start()
    {
        screenText = GameObject.Find("Win Message").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override protected void OnPlayerTouch(GameObject gameObject)
    {
        screenText.text = "You Win";
    }
}
