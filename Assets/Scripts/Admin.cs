using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Admin : MonoBehaviour
{
    public InputField UserName;
    public InputField Password;
    public Button Login;
    public Text message3;


    void Start()
    {
        Login.onClick.AddListener(() =>
        {
            StartCoroutine(Main.Instance.web.AdminLogin(UserName.text,Password.text));
        });
    }

    
}
