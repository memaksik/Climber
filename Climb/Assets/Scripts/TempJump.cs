using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempJump : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public void Left()
    {
        Player.GetComponent<Tempary>().Jump("Left");
    }


    public void Right()
    {
        Player.GetComponent<Tempary>().Jump("Right");
    }


    public void Start()
    {
        Player = GameObject.Find("Player");
    }


}
