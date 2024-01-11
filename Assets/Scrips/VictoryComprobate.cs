using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryComprobate : MonoBehaviour
{
    public GameObject victoryScreen;
    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0 && victoryScreen.activeSelf == false)
        {
            victoryScreen.SetActive(true);
        }
    }

    public void ResetGame()
    {
        Debug.Log("Reiniciar partida");
        SceneManager.LoadScene(0);
    }
}
