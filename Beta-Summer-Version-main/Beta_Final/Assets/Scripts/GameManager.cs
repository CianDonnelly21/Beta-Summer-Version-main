using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

public Button Alpha_Repo;
public Button Beta_Repo;
public Button EasyButton;
public Button MediumButton;
public Button HardButton;
public Button HelpButton;
public Button HomeButton;


void Start() 
    {
        Alpha_Repo.onClick.AddListener(Alpha_URL);
        Beta_Repo.onClick.AddListener(Beta_URL);
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

    void Alpha_URL()
    {
        Application.OpenURL("https://github.com/CianDonnelly21/Alpha_Summer_Version/tree/main");
    }

    void Beta_URL()
    {
        Application.OpenURL("https://github.com/CianDonnelly21/Beta-Summer-Version-main");
    }
}