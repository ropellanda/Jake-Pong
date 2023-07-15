using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{

    public float maxX = 9;
    public Rigidbody2D rb;
    public float speed = 5;

    public Text playerOneScoreTxt;
    public Text playerTwoScoreTxt;
    public Text timer;
    public GameObject timerObject;

    public int playerOneScore = 0;
    public int playerTwoScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        StartCoroutine(StartGame());
        SetScore();
    }

    void FixedUpdate()
    { 
        if (transform.position.x > maxX)
        {
            ResetGame();
            Debug.Log("Ponto do jogador 1");
            playerOneScore += 1;
            SetScore();
        } else
        {
            if (transform.position.x < -maxX)
            {
                ResetGame();
                Debug.Log("Ponto do jogador 2");
                playerTwoScore += 1;
                SetScore();
            }
        }
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    private void ResetGame()
    {
        rb.position = new Vector3(0, 0, 0);
        rb.velocity = Vector3.zero;
        StartCoroutine(StartGame());
    }

    private IEnumerator StartGame()
    {
        timerObject.SetActive(true);
        Debug.Log("Start");
        timer.text = "3";
        yield return new WaitForSeconds(1);
        timer.text = "2";
        yield return new WaitForSeconds(1);
        timer.text = "1";
        yield return new WaitForSeconds(1);
        timer.text = "0";
        timerObject.SetActive(false);
        Launch();
        Debug.Log("End");
    }

    private void SetScore()
    {
        playerOneScoreTxt.text = playerOneScore.ToString();
        playerTwoScoreTxt.text = playerTwoScore.ToString();
    }
}
