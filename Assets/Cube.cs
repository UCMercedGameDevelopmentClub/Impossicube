using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{


    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
      
        if (col.gameObject.name == "Player")
            OnPlayerTouch(col.gameObject);
    }

    virtual protected void OnPlayerTouch(GameObject gameObject)
    {
        Debug.Log("base");
    }

}
