using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    private float power;
    private String name;

    public Person(float power, String name)
    {
        this.name = name;
        this.power = power;
    }

    public void SetName(String name)
    {
        this.name = name;
    }

    public void SetPower(float power)
    {
        this.power = power;
    }

    public float GetPower()
    {
        return power;
    }

    public String GetName()
    {
        return name;
    }
    
 
}
