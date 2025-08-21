using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;


public class TimeManager : MonoBehaviour {
    
int seconds = 60;
public TextMeshProUGUI Time;

void Start()
{
StartCoroutine(Timer(1));
}

void Update()
{

}

IEnumerator Timer(int CountdownTimeLevel1)
{
    while (seconds > 0)

{
    yield return new WaitForSeconds(1);
    seconds -=CountdownTimeLevel1;
    Time.text = "" + seconds;
    
    if (seconds == 0)
    {
        SceneManager.LoadScene(5);
    }
}
}

}