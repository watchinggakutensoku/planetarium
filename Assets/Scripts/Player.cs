using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float playerSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPos = transform.position;
        if (Input.GetKey(KeyCode.D))
        {
            currentPos.x = currentPos.x + playerSpeed * Time.deltaTime;
            transform.position = currentPos;
        }
        if (Input.GetKey(KeyCode.A))
        {
            currentPos.x = currentPos.x - playerSpeed * Time.deltaTime;
            transform.position = currentPos;
        }
    }
}
