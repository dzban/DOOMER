using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    public bool isGrounded = false;
    public float MovementSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f); //getaxis bierze strzalki prawo i lewo i robi z tego wektor poruszania sie 
        transform.position += movement * Time.deltaTime * MovementSpeed; // przesuniecie

    }
    void Jump() {

        if (Input.GetButtonDown("Jump")&& isGrounded==true)
            gameObject.GetComponent<RigidBody2D>().AddForce(newVector2(0f, 5f), ForceMode2D.Impulse); //dodaje sile do rigidbody
    
    }
}
