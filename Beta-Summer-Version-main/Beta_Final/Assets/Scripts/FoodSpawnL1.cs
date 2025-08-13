using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FoodSpawnL1 : MonoBehaviour {

private GameManagerL1 gameManager;
public GameObject BananaOne;
public GameObject BananaTwo;
public GameObject BananaThree;
public GameObject BananaMan;
public GameObject CrouchMan;
public GameObject Cherry;
public GameObject Hotdog;
public GameObject HotdogTwo;
public GameObject HotdogThree;
public AudioSource GemCollectorAudio;
public AudioSource PortalGemAudio;
public AudioSource DeathAudio;
public AudioClip CollectSound;
public AudioClip PortalGemSound;
public AudioClip DeathSound;

void Start()
    {        
        gameManager = GameObject.Find("BananaOne").GetComponent<GameManagerL1>();
        gameManager = GameObject.Find("BananaTwo").GetComponent<GameManagerL1>();
        gameManager = GameObject.Find("BananaThree").GetComponent<GameManagerL1>();
        
        GemCollectorAudio = GetComponent<AudioSource>();
        PortalGemAudio = GetComponent<AudioSource>();
        DeathAudio = GetComponent<AudioSource>();

        BananaOne.gameObject.SetActive(true);
        BananaTwo.gameObject.SetActive(false);
        BananaThree.gameObject.SetActive(false);
        Cherry.gameObject.SetActive(false);
        Hotdog.gameObject.SetActive(true);
        HotdogTwo.gameObject.SetActive(true);
        HotdogThree.gameObject.SetActive(true);

        BananaOne.gameObject.transform.position = new Vector3(Random.Range(-5, 10), 6, -2);
    }

void Update()
    {  

    }

void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("BananaOne"))
        {
            gameManager.UpdateGems(1);
            GemCollectorAudio.PlayOneShot(CollectSound, 1.0f);
            BananaOne.gameObject.SetActive(false);
            BananaTwo.gameObject.SetActive(true);
            BananaTwo.gameObject.transform.position = new Vector3(Random.Range(-5, 10), 6, -2);
        }

        if(other.CompareTag("BananaTwo"))
        {
            gameManager.UpdateGems(1);
            GemCollectorAudio.PlayOneShot(CollectSound, 1.0f);
            BananaTwo.gameObject.SetActive(false);
            BananaThree.gameObject.SetActive(true);
            BananaThree.gameObject.transform.position = new Vector3(Random.Range(-5, 10), 6, -2);
        }

        if(other.CompareTag("BananaThree"))
        {
            gameManager.UpdateGems(1);
            GemCollectorAudio.PlayOneShot(CollectSound, 1.0f);
            BananaThree.gameObject.SetActive(false);
            Cherry.gameObject.SetActive(true);
        }
 
        if(other.CompareTag("Cherry"))
        {
            Cherry.gameObject.SetActive(false);
            PortalGemAudio.PlayOneShot(PortalGemSound, 1.0f);
            
            //How it loads next scene - Check
            int NextIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(NextIndex);
            
            BananaMan.gameObject.SetActive(false);
            CrouchMan.gameObject.SetActive(false);
            BananaOne.gameObject.SetActive(false);
            BananaTwo.gameObject.SetActive(false);
            BananaThree.gameObject.SetActive(false);
            Cherry.gameObject.SetActive(false);
        }

         if(other.CompareTag("Death"))
        {
            DeathAudio.PlayOneShot(DeathSound, 1.0f);
            gameManager.UpdateLives(1);
            BananaMan.gameObject.SetActive(false);
            CrouchMan.gameObject.SetActive(false);
            BananaOne.gameObject.SetActive(false);
            BananaTwo.gameObject.SetActive(false);
            BananaThree.gameObject.SetActive(false);
            Cherry.gameObject.SetActive(false);
            Hotdog.gameObject.SetActive(false);
            HotdogTwo.gameObject.SetActive(false);
            HotdogThree.gameObject.SetActive(false);

            SceneManager.LoadScene(5);
        }
    }
}