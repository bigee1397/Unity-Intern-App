using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Create : MonoBehaviour
{
    public InputField Username;
    public InputField Email;
    public InputField Password;
    public InputField FatherName;
    public InputField Age;
    public InputField Gender;
    public InputField Education;
    public InputField Designation;
    public InputField Mobilenumber;
    public InputField Address;
    public InputField City;
    public Button Signup;

   

    void Start()
    {
        Signup.onClick.AddListener(() =>
        {
            StartCoroutine(Main.Instance.web.CreateUser(Username.text, Email.text, Password.text, FatherName.text, Age.text, Gender.text, Education.text, Designation.text, Mobilenumber.text, Address.text, City.text));
        });
    }
}
