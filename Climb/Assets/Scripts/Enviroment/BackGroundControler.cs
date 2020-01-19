using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundControler : MonoBehaviour
{
    public GameObject Player;
    Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Player.GetComponent<CharacterControls>().speed != 0)
        {
            Move();
        }
    }
    
   
    
    public void Move()
    {
        position = new Vector3(0, 0.5f , 0);
        transform.position += position * Time.deltaTime;
    
    }
}
