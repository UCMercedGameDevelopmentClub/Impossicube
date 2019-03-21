using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularCube : Cube
{
    // Start is called before the first frame update

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override protected void OnPlayerTouch(GameObject gameObject)
    {
        Player player = gameObject.GetComponent<Player>();
        player.RefreshJump();
    }


}
