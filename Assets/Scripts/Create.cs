using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Create : MonoBehaviour
{
    public InputField Username;
    public InputField Email;
    public InputField Password;
    public InputField Repassword;
    public Button Signup;
    public Text message1;

    void Start()
    {
        Signup.onClick.AddListener(() =>
        {
            if(Password.text == Repassword.text)
            {
                StartCoroutine(Main.Instance.web.CreateUser(Username.text, Email.text, Password.text));
            }
            else
            {
                Debug.Log("Password Not Match");
                message1.text = "Password Not Match";
            }
            
        });
    }
}
