using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackGround : MonoBehaviour
{
    public float deltaY;
    public GameObject Background;
        public void Move()
        {
            Background.transform.position = new Vector2(transform.position.x , transform.position.y + deltaY);            
        }

}
