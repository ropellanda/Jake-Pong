using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float speed = 5;

    public Rigidbody2D firstPlayer;
    public Rigidbody2D secondPlayer;

    public Animator bmoAnimator;
    float bmoMove = 0f;

    public Animator finnAnimator;
    float finnMove = 0f;

    Vector2 firstPlayerMovement;
    Vector2 secondPlayerMovement;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        bmoMove = Input.GetAxisRaw("Vertical");
        if (bmoMove == -1 || bmoMove == 1)
        {
            bmoAnimator.SetBool("IsWalking", true);
        } else
        {
            bmoAnimator.SetBool("IsWalking", false);
        }

        finnMove = Input.GetAxisRaw("Vertical2");
        if (finnMove == -1 || finnMove == 1)
        {
            finnAnimator.SetBool("Walking", true);
        } else
        {
            finnAnimator.SetBool("Walking", false);
        }

        firstPlayerMovement.y = Input.GetAxisRaw("Vertical");
        secondPlayerMovement.y = Input.GetAxisRaw("Vertical2");
    }

    private void FixedUpdate()
    {
        firstPlayer.MovePosition(firstPlayer.position + firstPlayerMovement * speed * Time.deltaTime);
        secondPlayer.MovePosition(secondPlayer.position + secondPlayerMovement * speed * Time.deltaTime);
    }

}
