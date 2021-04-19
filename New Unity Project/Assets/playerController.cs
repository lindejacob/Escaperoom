using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    void Start()
    {
        rb2d.GetComponent<Rigidbody2D>();
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
            item = true;
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
        else if (collision.gameObject.name == "item8")
        {
            item8 = false;
            print("false");
        }
        else if (collision.gameObject.name == "item9")
        {
            item9 = false;
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
        if (Input.GetKeyDown(KeyCode.F) && item1 == true)
        {
            Destroy(GameObject.Find("item1"));
            PickedUp++;
            item1PickedUp = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && item2 == true)
        {
            Destroy(GameObject.Find("item2"));
            PickedUp++;
            item2PickedUp = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && item3 == true)
        {
            Destroy(GameObject.Find("item3"));
            PickedUp++;
            item3PickedUp = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && item4 == true)
        {
            Destroy(GameObject.Find("item4"));
            PickedUp++;
            item4PickedUp = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && item5 == true)
        {
            Destroy(GameObject.Find("item5"));
            PickedUp++;
            item5PickedUp = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && item6 == true)
        {
            Destroy(GameObject.Find("item6"));
            PickedUp++;
            item6PickedUp = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && item7 == true)
        {
            Destroy(GameObject.Find("item7"));
            PickedUp++;
            item7PickedUp = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && item8 == true)
        {
            Destroy(GameObject.Find("item8"));
            PickedUp++;
            item8PickedUp = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && item9 == true)
        {
            Destroy(GameObject.Find("item9"));
            PickedUp++;
            item9PickedUp = true;
        }

    }

    private void nextLevel()
    {
        if (door == true && Input.GetKeyDown("e") && PickedUp == 4)
        {
            SceneManager.LoadScene("køkken");
        }
    }


}


