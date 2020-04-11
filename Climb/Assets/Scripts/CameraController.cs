using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float zoomSpeed = 4f;
    public float targetOrtho;
    public float minZoom = 5;
    public float maxZoom = 16;
    public float delta = 0;
    public GameObject Person;
    public float WaitSecond = 20f;
    void Start()
    {
        Camera.main.GetComponent<Camera>().orthographicSize = maxZoom;
        Person.GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (WaitSecond > 0)
        {
            WaitSecond -= Time.timeScale;
            Debug.Log("До начала: " + WaitSecond);
        }
        else
        {
            delta = Camera.main.GetComponent<Camera>().orthographicSize - minZoom;
            ChangeSizeCamera(delta * 0.01f);
        }

        if (Camera.main.GetComponent<Camera>().orthographicSize < 5.4f) Person.GetComponent<Rigidbody2D>().gravityScale = 0.5f;
    }



    public void ChangeSizeCamera(float delta)
    {
            Camera.main.GetComponent<Camera>().orthographicSize = Mathf.Clamp(GetComponent<Camera>().orthographicSize - delta * zoomSpeed, minZoom, maxZoom);
    }

}
