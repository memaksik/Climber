using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour
{
    public float impulse = 4f;
    public GameObject Ground;
    public bool stay = true;
    public float speed;
  

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Debug.Log(gameObject.GetComponent<Rigidbody2D>().velocity.magnitude);
    }


    public void Jump()
    {
        //Vector3 v3Velocity = rb.velocity;

        speed = gameObject.GetComponent<Rigidbody2D>().velocity.magnitude;
        if (speed == 0 && Input.GetKeyUp(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(impulse, 0), ForceMode2D.Impulse);
            Ground.GetComponent<BackGroundControler>().Move();
        }
    }



}


    