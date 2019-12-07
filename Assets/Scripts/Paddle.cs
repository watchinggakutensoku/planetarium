using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
   float mousePosXInUnits;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosXInUnits = (Input.mousePosition.x * 360 / Screen.width) - 180;
        transform.rotation = Quaternion.AngleAxis(mousePosXInUnits, Vector3.back);
    }
}
