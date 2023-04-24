using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinnScript : MonoBehaviour
{
    public Animator finnAnim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "jake")
        {
            StartCoroutine(FinnCollision());
        }
    }

    private IEnumerator FinnCollision()
    { 
        finnAnim.SetBool("Collided", true);
        yield return new WaitForSeconds(0.5f);
        finnAnim.SetBool("Collided", false);
    }
}
