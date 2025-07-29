using UnityEngine;

public class BananMan_Movement : MonoBehaviour {

public float speed = 0.1f;
public GameObject CrouchMan;
public GameObject BananaMan;
public bool isOnGround = true;

void Start() 
    {
        BananaMan.gameObject.SetActive(true);
        CrouchMan.gameObject.SetActive(false);
    }

void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.forward * speed);

            BananaMan.gameObject.SetActive(true);
            CrouchMan.gameObject.SetActive(false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.back * speed);
        }

        if (Input.GetKey(KeyCode.UpArrow) && isOnGround)
        {
            transform.Translate(Vector3.up * 2);
            isOnGround = false;
        }
        //Double Jump
        if (Input.GetKey(KeyCode.Space) && isOnGround)
        {
            transform.Translate(Vector3.up * 5);
            isOnGround = false;
        }

        //Crouch 
        if (Input.GetKey(KeyCode.DownArrow))
        {
            BananaMan.transform.position = transform.position;

            CrouchMan.gameObject.SetActive(true);
            BananaMan.gameObject.SetActive(false);
        }
        else 
        {
            CrouchMan.transform.position = transform.position;

            CrouchMan.gameObject.SetActive(false);
            BananaMan.gameObject.SetActive(true);
        }
    }

        void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}