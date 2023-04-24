using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMOScript : MonoBehaviour
{
    public Animator BMOAnim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "jake")
        {
            StartCoroutine(Wait());
        }
    }

    private IEnumerator Wait()
    {
        BMOAnim.SetBool("HasCollided", true);
        yield return new WaitForSeconds(0.5f);
        BMOAnim.SetBool("HasCollided", false);
    }

}
