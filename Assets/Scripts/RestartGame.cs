using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    [SerializeField] Button restartButton;
    // Start is called before the first frame update
    void Start()
    {
        restartButton.onClick.AddListener(GameRestart);
    }

    // Update is called once per frame
    public void GameRestart()
    {
        SceneManager.LoadScene("StartMenuScene");
    }
}
