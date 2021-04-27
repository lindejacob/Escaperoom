using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public Rigidbody2D rb2d;

    private float verticalMove = 0.0f;
    private float horizontalMove = 0.0f;
    public float runspeed;

    private int PickedUp;

    //items touched
    private bool item1 = false;
    private bool item2 = false;
    private bool item3 = false;
    private bool item4 = false;
    private bool item5 = false;
    private bool item6 = false;
    private bool item7 = false;
    private bool item8 = false;
    private bool item9 = false;
    private bool door = false;

    private bool finalItem1 = false;
    private bool finalItem2 = false;
    private bool finalItem3 = false;

    //items pickedup
    private bool item1PickedUp = false;
    private bool item2PickedUp = false;
    private bool item3PickedUp = false;
    private bool item4PickedUp = false;
    private bool item5PickedUp = false;
    private bool item6PickedUp = false;
    private bool item7PickedUp = false;
    private bool item8PickedUp = false;
    private bool item9PickedUp = false;

    private bool finalItem1PickedUp = false;
    private bool finalItem2PickedUp = false;
    private bool finalItem3pickedUp = false;

    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject finalItem_1;
    public GameObject image4;
    public GameObject image5;
    public GameObject image6;
    public GameObject finalItem_2;
    public GameObject image7;
    public GameObject image8;
    public GameObject image9;
    public GameObject finalItem_3;


    void Start()
    {
        rb2d.GetComponent<Rigidbody2D>();
        image1.SetActive(false);
        image2.SetActive(false);
        image3.SetActive(false);
        image4.SetActive(false);
        image5.SetActive(false);
        image6.SetActive(false);
        image7.SetActive(false);
    }
    void Update()
    {
        print(PickedUp);
        nextLevel();
        pickup();

        
    }
    private void FixedUpdate()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");
        rb2d.velocity = new Vector3(horizontalMove, verticalMove, 0.0f) * runspeed;
       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "item1")
        {
            item1 = true;
            print("True");
        }
        else if (collision.gameObject.name == "item2")
        {
            item2 = true;
            print("true");
        }
        else if (collision.gameObject.name == "item3")
        {
            item3 = true;
            print("true");
        }

        else if (collision.gameObject.name == "item4")
        {
            item4 = true;
            print("true");
        }
        else if (collision.gameObject.name == "item5")
        {
            item5 = true;
            print("true");
        }
        else if (collision.gameObject.name == "item6")
        {
            item6 = true;
            print("true");
        }

        else if (collision.gameObject.name == "item7")
        {
            item7 = true;
            print("true");
        }
        else if (collision.gameObject.name == "item8")
        {
            item8 = true;
            print("true");
        }
        else if (collision.gameObject.name == "item9")
        {
            item9 = true;
            print("true");
        }
        else if (collision.gameObject.name == "finalItem1")
        {
            finalItem1 = true;
            print("true");
        }
        else if (collision.gameObject.name == "finalItem2")
        {
            finalItem2 = true;
            print("true");
        }
        else if (collision.gameObject.name == "finalItem3")
        {
            finalItem3 = true;
            print("true");
        }
        else if (collision.gameObject.name == "door")
        {
            door = true;
            print("true");
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "item1")
        {
            item1 = false;
            print("False");
        }

        else if (collision.gameObject.name == "item2")
        {
            item2 = false;
            print("false");
        }
        else if (collision.gameObject.name == "item3")
        {
            item3 = false;
            print("false");
        }

        else if (collision.gameObject.name == "item4")
        {
            item4 = false;
            print("false");
        }
        else if (collision.gameObject.name == "item5")
        {
            item5 = false;
            print("false");
        }
        else if (collision.gameObject.name == "item6")
        {
            item6 = false;
            print("false");
        }

        else if (collision.gameObject.name == "item7")
        {
            item7 = false;
            print("false");
        }

        else if (collision.gameObject.name == "finalItem1")
        {
            finalItem1 = false;
            print("false");
        }
        else if (collision.gameObject.name == "finalItem2")
        {
            finalItem2 = false;
            print("false");
        }
        else if (collision.gameObject.name == "finalItem3")
        {
            finalItem3 = false;
            print("false");
        }

        else if (collision.gameObject.name == "door")
        {
            door = false;
            print("false");
        }
    }
    private void pickup()
    {
        if (Input.GetKeyDown(KeyCode.F) && item1 == true) //maleri
        {
            Destroy(GameObject.Find("item1"));
            PickedUp++;
            item1PickedUp = true;
            image1.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.F) && item2 == true) //bog
        {
            Destroy(GameObject.Find("item2"));
            PickedUp++;
            item2PickedUp = true;
            image2.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.F) && item3 == true) //brev
        {
            Destroy(GameObject.Find("item3"));
            PickedUp++;
            item3PickedUp = true;
            image3.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.F) && item4 == true) //nøgle
        {
            Destroy(GameObject.Find("item4"));
            PickedUp = 4;
            item4PickedUp = true;
            image4.SetActive(true);
        }

        else if (Input.GetKeyDown(KeyCode.F) && item5 == true) // manual
        {
            Destroy(GameObject.Find("item5"));
            PickedUp = 5;
            item5PickedUp = true;
            image5.SetActive(true);
        }

        else if (Input.GetKeyDown(KeyCode.F) && PickedUp == 5) // bolt
        {
            Destroy(GameObject.Find("item6"));
            PickedUp++;
            item6PickedUp = true;
            image6.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.F) && item7 == true && item6PickedUp == true && item5PickedUp == true )
        {
            Destroy(GameObject.Find("item7"));
            PickedUp++;
            item7PickedUp = true;
            image5.SetActive(false);
            image6.SetActive(false);
        }


    }
    private void nextLevel()
    {
        if (door == true && Input.GetKeyDown("f") && PickedUp == 3)
        {
            SceneManager.LoadScene("køkken");
        }

        else if (door == true && Input.GetKeyDown("f") && PickedUp == 4)
        {
            SceneManager.LoadScene("garage");
        }

        else if (door == true && Input.GetKeyDown("f") && item7PickedUp == true)
        {
            SceneManager.LoadScene("win");
        }
    }
}


