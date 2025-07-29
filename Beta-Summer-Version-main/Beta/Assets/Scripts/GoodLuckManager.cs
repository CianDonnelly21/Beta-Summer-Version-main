using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GoodLuckManager : MonoBehaviour {

public Button HomeButton;

    void Start()
    {
        HomeButton.onClick.AddListener(MainMenu);
    }

    void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}