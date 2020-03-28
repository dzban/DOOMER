using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject; //tu trzeba zrobic obiekt jako dziecko playera- groundcheck
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) //poczatek kolizji
    {
        if (collision.collider.tag == "Ground") //sprawdza czy jest ground
        {
            Player.GetComponent<Movement2D>().isGrounded = true;

        }
    }
    private void OnCollisionExit2D(Collision2D collision) //koniec kolizji
    {
        if (collision.collider.tag == "Ground") //tu tez sprawdza  
        {
            Player.GetComponent<Movement2D>().isGrounded = false;
        }
    }
}
