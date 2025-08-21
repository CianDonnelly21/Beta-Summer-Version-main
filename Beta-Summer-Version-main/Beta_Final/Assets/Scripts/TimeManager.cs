using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;


public class TimeManager : MonoBehaviour {
    
int seconds = 60;
public TextMeshProUGUI Time;
public AudioSource WarningAudio;
public AudioClip WarningSound;

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

    if (seconds == 10)
    {
        WarningAudio.PlayOneShot(WarningSound, 1.0f);
    }
    
    if (seconds == 0)
    {
        SceneManager.LoadScene(5);
    }
}
}

}