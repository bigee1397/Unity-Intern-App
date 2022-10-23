using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Searchuser : MonoBehaviour
{
    //public InputField EnterId;
    //public Text message4;
    public Button Search;
    //string s = EnterId.text;
    //int x=
    //int x = Int32.Parse();

    void Start()
    {
        Search.onClick.AddListener(() =>
        {
            StartCoroutine(Main.Instance.web.Search(Drapdown.Username));
        });
    }
}
