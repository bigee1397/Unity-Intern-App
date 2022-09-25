using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Update : MonoBehaviour
{
    public InputField Email;
    public InputField NewPassword;
    public InputField ReNewPassword;
    public Button Submit;
    public Text message2;


    void Start()
    {
        Submit.onClick.AddListener(() =>
        {
            if (NewPassword.text == ReNewPassword.text)
            {
                StartCoroutine(Main.Instance.web.UpdateDetails(Email.text, NewPassword.text));
            }
            else
            {
                message2.text = "Both Password Not Match";
            }

        });
    }

    
}
