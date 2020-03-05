using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skript : MonoBehaviour
{
    public int Test = 69;
    public GameObject NamensAenderung;
    public string Name;
    public float xPos;
    void Start()
    {
        Debug.Log(Test);
        Debug.Log(xPos);
    }
    void Update()
    {
        NamensAenderung.name = Name;
        xPos = NamensAenderung.transform.position.x;
    }
}
