using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchUserData : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Searchusername;
   // public Text SearchuserNamed;
    public Text SearchuserEmail;
    public Text SearchuserPassword;
    public Text SearchFatherName;
    public Text SearchAge;
    public Text SearchGender;
    public Text SearchEducation;
    public Text SearchDesignation;
    public Text SearchMobilenumber;
    public Text SearchAddress;
    public Text SearchCity;

    public void ViewUserData()
    {
        Searchusername.text = web.SearchuserName;
        SearchuserEmail.text=web.SearchuserEmail;
        SearchuserPassword.text = web.SearchuserPassword;
        SearchFatherName.text = web.SearchFatherName;
        SearchAge.text= web.SearchAge;
        SearchGender.text = web.SearchGender;
        SearchEducation.text = web.SearchEducation;
        SearchDesignation.text = web.SearchDesignation;
        SearchMobilenumber.text = web.SearchMobilenumber;
        SearchAddress.text = web.SearchAddress;
        SearchCity.text = web.SearchCity;


    }
}
