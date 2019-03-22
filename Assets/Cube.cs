using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    protected GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
