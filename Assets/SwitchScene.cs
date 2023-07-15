using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void StartGame(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
