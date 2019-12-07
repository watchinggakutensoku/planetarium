using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float jumpForce = 1200f;
    [SerializeField] GameObject fly;

    bool jumpGo = false;
    
    // Start is called before the first frame update
    void Start()
    {
        jumpGo = fly.GetComponent<fly>().jumpOk;
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpGo)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody2D>().AddForce(transform.up * jumpForce);
            }
        }
    }
}
