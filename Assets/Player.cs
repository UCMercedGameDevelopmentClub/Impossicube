using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameManager gameManager;

    Rigidbody rb;
    Quaternion q;
    bool jump;
    Vector3 start_pos;
    // Start is called before the first frame update
    void Start()
    {
        start_pos = transform.position;
        rb = GetComponent<Rigidbody>();
        q = transform.rotation;
        jump = true;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")){
            rb.AddForce(new Vector3 (-1f,0.0f,0.0f) , ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")){
            rb.AddForce(new Vector3 (0.0f,0.0f,-1f), ForceMode.VelocityChange);
        }
        if (Input.GetKey("s")){
            rb.AddForce(new Vector3 (1f,0.0f,0.0f), ForceMode.VelocityChange);
        }
        if (Input.GetKey("d")){
            rb.AddForce(new Vector3 (0.0f,0.0f,1f), ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown("space") && jump == true){
            rb.AddForce(new Vector3 (0.0f, 10.0f,0.0f), ForceMode.Impulse);
            jump = false;
        }

        if (Input.GetKeyDown("r")){
            Reset();
        }

        if (transform.position.y < -15f){
            Reset();
        }
    }

    void Reset(){
        transform.position = start_pos;
        rb.velocity = new Vector3 (0f,0f,0f);
        transform.rotation = q;
        rb.angularVelocity =  new Vector3 (0f,0f,0f);
        jump = true;
        gameManager.ResetTimer();
    }

    public void RefreshJump(){
        jump = true;
    }
}
