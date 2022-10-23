using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getData : MonoBehaviour
{
    public Text AName;
    public Text APassword;
    public Text AEmail;
    public Text AAge;
    public Text AGender;
    public Text AEducation;
    public Text ADesignation;
    public Text AMobilenumber;
    public Text AAddress;
    public Text ACity;
    public Text AExpereince;

    public void Show()
    {
        AName.text = web.Aname;
        AEmail.text = web.AEmail;
        APassword.text = web.Apassword;
        AAge.text = web.AAge;
        AGender.text = web.AGender;
        AEducation.text = web.AEducation;
        ADesignation.text = web.ADesignation;
        AMobilenumber.text = web.AMobilenumber;
        AAddress.text = web.AAddress;
        ACity.text = web.ACity;
        AExpereince.text = web.AExpereince;
    }
}
