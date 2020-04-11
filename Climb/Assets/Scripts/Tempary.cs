using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tempary : MonoBehaviour
{
    // Start is called before the first frame update
    public float deltaX = 10f;
    public float deltaY = 10f;
    protected int CountJump = 2;
    protected GameObject gameob;
    public Text text;

    public void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            FixedJoint2D fjR = gameObject.AddComponent<FixedJoint2D>() as FixedJoint2D;
            fjR.connectedBody = gameob.GetComponent<Rigidbody2D>();
        }


        text.text = "Кол-во прыжко: " + CountJump.ToString();

    }

    protected GameObject go_temp;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        go_temp = collision.gameObject;
       FixedJoint2D fjR = gameObject.AddComponent<FixedJoint2D>() as FixedJoint2D;
       fjR.connectedBody = collision.gameObject.GetComponent<Rigidbody2D>();
        CountJump = 2;


    }


/*    public void OnCollisionExit(Collision collision)
    {
        Destroy(gameObject.GetComponent<FixedJoint>());    
    }*/


    public void DestroyCollider(GameObject go)
    {
        go.GetComponent<Shape>().WithoutColliderOnTime();
    }



    public void Jump(string str)
    {
        Destroy(gameObject.GetComponent<FixedJoint2D>());
        DestroyCollider(go_temp);
        
        if (str == "Right" && CountJump >0)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(deltaX, deltaY), ForceMode2D.Force);
            CountJump--;
        }
        if(str == "Left" && CountJump > 0)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-deltaX, deltaY), ForceMode2D.Force);
            CountJump--;
        }
        
    }



}
