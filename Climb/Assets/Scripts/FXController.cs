using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXController : MonoBehaviour
{

    public GameObject FX;
    public void StartFX()
    {
        Instantiate(FX, new Vector2(gameObject.transform.position.x , gameObject.transform.position.y), Quaternion.identity);
    }

}
