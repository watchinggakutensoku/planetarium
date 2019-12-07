using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBlock : MonoBehaviour
{
    [SerializeField] GameObject blockSparkVFX;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            DestroyBlock();
        }
    }

    private void DestroyBlock()
    {
        Destroy(gameObject);
        TriggerSparklesVFX();
    }

    private void TriggerSparklesVFX()
    {
        GameObject sparkles = Instantiate(blockSparkVFX, transform.position, transform.rotation);
        Destroy(sparkles, 0.7f);
    }
}
