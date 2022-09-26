using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField Username;
    public InputField Password;
    public Button Button;
    
    void Start()
    {
        //Main.Instance.web.Upload()
        Button.onClick.AddListener(() =>
        {
            StartCoroutine(Main.Instance.web.Upload(Username.text, Password.text));
        });
    }

}
