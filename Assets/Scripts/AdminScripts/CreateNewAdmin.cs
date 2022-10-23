using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateNewAdmin : MonoBehaviour
{
    public InputField Username;
    public InputField Email;
    public InputField Password;
    public InputField Expereince;
    public InputField Age;
    public InputField Gender;
    public InputField Education;
    public InputField Designation;
    public InputField Mobilenumber;
    public InputField Address;
    public InputField City;
    public Button CreateNewUser;

    void Start()
    {
        CreateNewUser.onClick.AddListener(() =>
        {
            StartCoroutine(Main.Instance.web.Createnewadmin(Username.text, Email.text, Password.text, Age.text, Gender.text, Education.text, Address.text, City.text, Designation.text, Mobilenumber.text, Expereince.text));

        });
    }
}