using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;


public class TimeManagerL3 : MonoBehaviour {
    
int seconds = 30;
public TextMeshProUGUI Time;

void Start()
{
StartCoroutine(Timer(1));
}

void Update()
{

}

IEnumerator Timer(int CountdownTimeLevel3)
{
    while (seconds > 0)

{
    yield return new WaitForSeconds(1);
    seconds -=CountdownTimeLevel3;
    Time.text = "" + seconds;
    
    if (seconds == 0)
    {
        SceneManager.LoadScene(5);
    }
}
}

}