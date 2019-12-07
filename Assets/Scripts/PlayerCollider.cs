using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollider : MonoBehaviour
{
    [SerializeField] List<GameObject> heart;
    [SerializeField] GameObject ball;
    
    int loseCount = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == ball)
        {
            Destroy(heart[loseCount]);
            loseCount++;
            StartCoroutine(WaitBeforeDamage());
        }
    }

    IEnumerator WaitBeforeDamage()
    {
        yield return new WaitForSeconds(1f);
    }

    private void Update()
    {
        if(loseCount == 4)
        {
            StartCoroutine(GameOver());
        }
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(0.5f);
        FindObjectOfType<SceneLoader>().LoadGameOverScene();
    }
}
