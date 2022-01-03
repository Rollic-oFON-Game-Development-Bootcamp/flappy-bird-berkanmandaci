using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Canvas canvas;

    private static GameManager instance=null;

    public static GameManager GetInstance()
    {
        if (instance == null)
            instance = new GameManager();
        return instance;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void FinishGame()
    {
        canvas.gameObject.SetActive(false);
    }
}
