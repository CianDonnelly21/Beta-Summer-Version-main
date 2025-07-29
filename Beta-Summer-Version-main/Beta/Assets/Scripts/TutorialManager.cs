using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TutorialManager : MonoBehaviour {

public Button NextButton;

    void Start()
    {
        NextButton.onClick.AddListener(GoodLuck);
    }
    
    void GoodLuck()
    {
        SceneManager.LoadScene(7);
    }
}