using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] Button startGameButton;

    public void GameInit()
    {
        SceneManager.LoadScene("Level1Scene");
    }
    // Start is called before the first frame update
    void Start()
    {
        startGameButton.onClick.AddListener(GameInit);
    }
}
