using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundControler : MonoBehaviour
{
    public GameObject Player;
    Vector3 position;

    public GameObject[] Background;
    public GameObject[] BackgroundsVariation;
    private Vector2 StartBackPosition = new Vector2(-6.66f, -1.479999f);
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
        if (gameObject.transform.position.y > 0.0f) ChangeBack(Random.Range(0, 3));
    }
    
   
    
    public void Move()
    {
        position = new Vector3(0, 0.5f , 0);
        transform.position += position * Time.deltaTime;
        
    }


    void ChangeBack(int i)
    {
        Destroy(gameObject);
        Instantiate(Background[i], StartBackPosition, Quaternion.identity);
    }
}
