using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    // Start is called before the first frame update

    public float rotate = 2;
    public float timeForNewCollider = 2f;
    public bool Circle = false;
    public bool Triangle = false;
    public bool Square = false;
    protected bool B_FX = true;
    public GameObject FX;
    public GameObject Core;
    public Color color;


    /*   public void OnCollisionStay(Collision collision)
       {
           rotate = 2f;
        //  gameObject.transform.Rotate(0, 0, rotate); 
       }


       public void OnCollisionExit(Collision collision)
       {
           rotate = 0f;
       }*/
    public void Start()
    {
        Core.SetActive(false) ;
        // color = Core.GetComponent<SpriteRenderer>().color;
        // Core.GetComponent<SpriteRenderer>().color = new Color(1,1,1,0);
    }




    public void OnCollisionEnter2D(Collision2D collision)
    {
        FXControl();
        ActiveCore();
    }

    public void WithoutColliderOnTime()
    {
        if(Square == true)
            {
            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            }
        else if (Circle == true)
            {
            gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
            }
        else if (Triangle == true)
            {
            gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;
            }
        
        Invoke("GetBoxCollider", timeForNewCollider);
    }

    public void GetBoxCollider()
    {
        if (Square == true)
        {
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
        }
        if (Circle == true)
        {
            gameObject.GetComponent<CircleCollider2D>().isTrigger = false;
        }
        if (Triangle == true)
        {
            gameObject.GetComponent<PolygonCollider2D>().isTrigger = false;
        }
        Debug.Log("Новый коллайдер создан");
    }



    public void FXControl()
    {
        FX.GetComponent<FXController>().StartFX();
    }


    public void ActiveCore()
    {
        Core.SetActive(true);
    }







}
