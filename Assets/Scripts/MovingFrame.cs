using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFrame : MonoBehaviour
{
    Vector2 currentPos;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = transform.position;
        currentPos.x = FindObjectOfType<Player>().transform.position.x + 5;
        transform.position = currentPos;
    }
}
