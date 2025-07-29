using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

//Scene Changer

//Text in game eg. gems collected, health, and time
public Button PlayButton;
public Button EasyButton;
public Button MediumButton;
public Button HardButton;
public Button HelpButton;
public Button HomeButton;


void Start() 
    {
        PlayButton.onClick.AddListener(LevelOne);
        EasyButton.onClick.AddListener(LevelOne);
        MediumButton.onClick.AddListener(LevelTwo);
        HardButton.onClick.AddListener(LevelThree);
        HelpButton.onClick.AddListener(Tutorial);
    }

void Update()
    {

    }

void MainMenu()
{
    SceneManager.LoadScene(0);
    }
void LevelOne()
    {
        SceneManager.LoadScene(1);
    }

    void LevelTwo()
    {
        SceneManager.LoadScene(2);
    }

    void LevelThree()
    {
        SceneManager.LoadScene(3);
    }

    void Win()
    {
        SceneManager.LoadScene(4);
    }

    void Lose()
    {
        SceneManager.LoadScene(5);
    }

    void Tutorial()
    {
        SceneManager.LoadScene(6);
    }

    void GoodLuck()
    {
        SceneManager.LoadScene(7);
    }
}