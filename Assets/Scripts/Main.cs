using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static Main Instance;
    public web web;
    //public getData getData;
    void Start()
    {
        Instance = this;
        web = GetComponent<web>();
        //getData = GetComponent<getData>();
    }
}
