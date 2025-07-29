using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerL1 : MonoBehaviour {

//Scene Changer

//Text in game eg. gems collected, health, and time
public Button HomeButton;

public int gems;
public TextMeshProUGUI Gems;

public int Life;
public TextMeshProUGUI Lives;

void Start() 
    {
        HomeButton.onClick.AddListener(MainMenu);
        gems = 3;
        Life = 1;
    }

void Update()
    {

    }

public void UpdateGems(int NumberOfGems)
    {
        gems -= NumberOfGems;
        Gems.text = "Bananas: " + gems;
    }

public void UpdateLives(int NumberOfLives)
    {
        Life -= NumberOfLives;
        Lives.text = "Lives: " + Life;
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
}