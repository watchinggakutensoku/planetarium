using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float ballSpeed = 10;
    [SerializeField] AudioClip bulletSE;
    [SerializeField] AudioClip damageSE;
    [SerializeField] GameObject playerObj;

    Vector2 velocityNow;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(-12, -10));
    }

    // Update is called once per frame
    void Update()
    {
        ConstantSpeed();
    }

    private void ConstantSpeed()
    {
        velocityNow = GetComponent<Rigidbody2D>().velocity;
        velocityNow.Normalize();
        GetComponent<Rigidbody2D>().velocity = velocityNow * ballSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == playerObj)
        {
            Debug.Log("HIT");
            AudioSource.PlayClipAtPoint(damageSE, Camera.main.transform.position);
        }
        else
        {
            AudioSource.PlayClipAtPoint(bulletSE, Camera.main.transform.position);
        }
    }
}
