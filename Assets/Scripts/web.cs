using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class web : MonoBehaviour
{


    [SerializeField] GameObject DisplayButton;



    public Text message;
    public Text message1;
    public Text message2;
    public Text message3;
    public Text message4;
    public Text message5;
    public Text message6;
    public Text message7;
    public Text display;




    //Login Admin Details
    public static string Aname;
    public static string Aid;
    public static string Apassword;
    public static string AEmail;
    public static string AAge;
    public static string AGender;
    public static string AEducation;
    public static string ADesignation;
    public static string AMobilenumber;
    public static string AAddress;
    public static string ACity;
    public static string AExpereince;




    //Login User Details
    public static string Loginuserid;
    public static string Loginusername;
    public static string Loginuserpassword;
    public static string LoginuserEmail;
    public static string LoginuserFatherName;
    public static string LoginuserAge;
    public static string LoginuserGender;
    public static string LoginuserEducation;
    public static string LoginuserDesignation;
    public static string LoginuserMobilenumber;
    public static string LoginuserAddress;
    public static string LoginuserCity;
    




    //Search User Details
    public static string SearchuserId;
    public static string SearchuserName;
    public static string SearchuserEmail;
    public static string SearchuserPassword;
    public static string SearchFatherName;
    public static string SearchAge;
    public static string SearchGender;
    public static string SearchEducation;
    public static string SearchDesignation;
    public static string SearchMobilenumber;
    public static string SearchAddress;
    public static string SearchCity;








    //User Login
    public IEnumerator Upload(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);
        Loginuserid = "";
        Loginusername = "";
        LoginuserEmail = "";
        Loginuserpassword = "";
        LoginuserFatherName = "";
        LoginuserAge = "";
        LoginuserGender = "";
        LoginuserEducation = "";
        LoginuserDesignation = "";
        LoginuserMobilenumber = "";
        LoginuserAddress = "";
        LoginuserCity = "";

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/SQL/Login.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
                message.text = www.error;
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                string s = www.downloadHandler.text;
                string[] splitArray = s.Split(char.Parse("_"));
                if ("Login Success" == splitArray[0])
                {
                    Loginuserid = splitArray[1];
                    Loginusername = splitArray[2];
                    LoginuserEmail = splitArray[3];
                    Loginuserpassword = splitArray[4];
                    LoginuserFatherName = splitArray[5];
                    LoginuserAge = splitArray[6];
                    LoginuserGender = splitArray[7];
                    LoginuserEducation = splitArray[8];
                    LoginuserDesignation = splitArray[9];
                    LoginuserMobilenumber = splitArray[10];
                    LoginuserAddress = splitArray[11];
                    LoginuserCity = splitArray[12];
                    Debug.Log(Loginuserid);
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        }
    }





    //Create New User
    public IEnumerator CreateUser(string username, string email, string password,string fath, string age, string gender, string education, string designation, string mobilenumber, string address, string city)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginEmail", email);
        form.AddField("loginPass", password);
        form.AddField("loginfather_name", fath);
        form.AddField("age", age);
        form.AddField("gender", gender);
        form.AddField("education", education);
        form.AddField("designation", designation);
        form.AddField("mobilenumber", mobilenumber);
        form.AddField("address", address);
        form.AddField("city", city);
        Loginuserid = "";
        Loginusername = "";
        LoginuserEmail = "";
        Loginuserpassword = "";
        LoginuserFatherName = "";
        LoginuserAge = "";
        LoginuserGender = "";
        LoginuserEducation = "";
        LoginuserDesignation = "";
        LoginuserMobilenumber = "";
        LoginuserAddress = "";
        LoginuserCity = "";

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/SQL/CreateAccount.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
                message1.text = www.error;
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                //message1.text = www.downloadHandler.text;
                string s = www.downloadHandler.text;
                string[] splitArray = s.Split(char.Parse("_"));
                if ("good" == splitArray[0])
                {
                    Loginuserid = splitArray[1];
                    Loginusername = splitArray[2];
                    LoginuserEmail = splitArray[3];
                    Loginuserpassword = splitArray[4];
                    LoginuserFatherName = splitArray[5];
                    LoginuserAge = splitArray[6];
                    LoginuserGender = splitArray[7];
                    LoginuserEducation = splitArray[8];
                    LoginuserDesignation = splitArray[9];
                    LoginuserMobilenumber = splitArray[10];
                    LoginuserAddress = splitArray[11];
                    LoginuserCity = splitArray[12];
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        }
    }




    //Create New Admin
    public IEnumerator Createadmin(string username, string email, string password, string age, string gender, string education, string address, string city, string designation, string mobilenumber, string expereince)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginEmail", email);
        form.AddField("loginPass", password);
        form.AddField("age", age);
        form.AddField("gender", gender);
        form.AddField("education", education);
        form.AddField("address", address);
        form.AddField("city", city);
        form.AddField("designation", designation);
        form.AddField("mobilenumber", mobilenumber);
        form.AddField("expereince", expereince);
        Aid = "";
        Aname = "";
        AEmail = "";
        Apassword = "";
        AAge = "";
        AGender = "";
        AEducation = "";
        ADesignation = "";
        AMobilenumber = "";
        AAddress = "";
        ACity = "";
        AExpereince = "";


        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/SQL/CreateAdmin.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
                //message7.text = www.error;
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                string s = www.downloadHandler.text;
                string[] splitArray = s.Split(char.Parse("_"));
                if ("New Account created successfully Login"== splitArray[0])
                {
                    Aid = splitArray[1];
                    Aname = splitArray[2];
                    AEmail = splitArray[3];
                    Apassword = splitArray[4];
                    AAge = splitArray[5];
                    AGender = splitArray[6];
                    AEducation = splitArray[7];
                    ADesignation = splitArray[8];
                    AMobilenumber = splitArray[9];
                    AAddress = splitArray[10];
                    ACity = splitArray[11];
                    AExpereince = splitArray[12];
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                }
                //message7.text = www.downloadHandler.text;

            }
        }
    }





    //Forgot Password  Update User Details
    public IEnumerator UpdateDetails(string email, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginEmail", email);
        form.AddField("loginPass", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/SQL/EditDetails.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
                message2.text = www.error;
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                message2.text = www.downloadHandler.text;
            }
        }
    }





    //Admin Login
    public IEnumerator AdminLogin(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);
        Aid = "";
        Aname = "";
        AEmail = "";
        Apassword = "";
        AAge = "";
        AGender = "";
        AEducation = "";
        ADesignation = "";
        AMobilenumber = "";
        AAddress = "";
        ACity = "";
        AExpereince = "";

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/SQL/Admin.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
                message3.text = www.error;
            }
            else
            {
                
                Debug.Log(www.downloadHandler.text);
                string s = www.downloadHandler.text;
                string[] splitArray = s.Split(char.Parse("_"));
                message3.text = splitArray[0];
                
                if ("nice" == splitArray[0])
                {
                    Aid = splitArray[1];
                    Aname = splitArray[2];
                    AEmail = splitArray[3];
                    Apassword = splitArray[4];
                    AAge = splitArray[5];
                    AGender = splitArray[6];
                    AEducation = splitArray[7];
                    ADesignation = splitArray[8];
                    AMobilenumber = splitArray[9];
                    AAddress = splitArray[10];
                    ACity = splitArray[11];
                    AExpereince = splitArray[12];
                    //Display.interactable = false;
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

                    

                }
            }
        }
    }





    //Update Admin Details
    public IEnumerator ProfileUpdate(string AdminId, string username, string email, string password, string age, string gender, string education, string address, string city, string designation, string mobilenumber, string expereince)
    {
        WWWForm form = new WWWForm();
        form.AddField("AdminId", AdminId);
        form.AddField("loginUser", username);
        form.AddField("loginEmail", email);
        form.AddField("loginPass", password);
        form.AddField("age", age);
        form.AddField("gender", gender);
        form.AddField("education", education);
        form.AddField("address", address);
        form.AddField("city", city);
        form.AddField("designation", designation);
        form.AddField("mobilenumber", mobilenumber);
        form.AddField("loginfather_name", expereince);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/SQL/AdminProfileUpdate.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                string s = www.downloadHandler.text;
                string[] splitArray = s.Split(char.Parse("_"));
                if("Record updated successfully" == splitArray[0])
                {
                    Aname = splitArray[1];
                    Apassword = splitArray[2];
                }
                
            }
        }
    }





    //Create New User By Admin
    public IEnumerator CreateNewUserByAdmin(string username, string email, string password, string fath, string age, string gender, string education, string designation, string mobilenumber, string address, string city)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginEmail", email);
        form.AddField("loginPass", password);
        form.AddField("loginfather_name", fath);
        form.AddField("age", age);
        form.AddField("gender", gender);
        form.AddField("education", education);
        form.AddField("designation", designation);
        form.AddField("mobilenumber", mobilenumber);
        form.AddField("address", address);
        form.AddField("city", city);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/SQL/CreateNewUserByadmin.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
                message6.text = www.error;
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                message6.text = www.downloadHandler.text;
            }
        }
    }





    //Create new Admin By Admin
    public IEnumerator Createnewadmin(string username, string email, string password, string age, string gender, string education, string address, string city, string designation, string mobilenumber, string expereince)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginEmail", email);
        form.AddField("loginPass", password);
        form.AddField("age", age);
        form.AddField("gender", gender);
        form.AddField("education", education);
        form.AddField("address", address);
        form.AddField("city", city);
        form.AddField("designation", designation);
        form.AddField("mobilenumber", mobilenumber);
        form.AddField("loginfather_name", expereince);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/SQL/CreateNewadmin.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
                message7.text = www.error;
            }
            else
            {

                Debug.Log(www.downloadHandler.text);
                message7.text = www.downloadHandler.text;

            }
        }
    }





   //Delete User from Admin
    public IEnumerator DeleteUseradmin(string Id)
    {
        WWWForm form = new WWWForm();
        form.AddField("UserId", Id);
        DisplayButton.SetActive(false);
        message5.text = "";

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/SQL/DeleteUserByAdmin.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
                message4.text = www.error;
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                message5.text = www.downloadHandler.text;

            }
        }
    }




    //user Search from Admin
    public IEnumerator Search(string Id)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginId", Id);
        message5.text = "";
        message4.text = "";
        SearchuserId = "";
        SearchuserName = "";
        SearchuserEmail = "";
        SearchuserPassword = "";
        SearchFatherName = "";
        SearchAge = "";
        SearchGender = "";
        SearchEducation = "";
        SearchDesignation = "";
        SearchMobilenumber = "";
        SearchAddress = "";
        SearchCity = "";
        DisplayButton.SetActive(false);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/SQL/SearchUser.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
                message4.text = www.error;
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                string s = www.downloadHandler.text;
                string[] splitArray = s.Split(char.Parse("_"));
                if (Id == splitArray[1])
                {
                    DisplayButton.SetActive(true);
                    message4.text = splitArray[1];
                    SearchuserId = splitArray[0];
                    SearchuserName = splitArray[1];
                    SearchuserEmail = splitArray[2];
                    SearchuserPassword = splitArray[3];
                    SearchFatherName = splitArray[4];
                    SearchAge = splitArray[5];
                    SearchGender = splitArray[6];
                    SearchEducation = splitArray[7];
                    SearchDesignation = splitArray[8];
                    SearchMobilenumber = splitArray[9];
                    SearchAddress = splitArray[10];
                    SearchCity = splitArray[11];
                }
                else
                {
                    message5.text = splitArray[0];
                }
                
            }
        }
    }





    //Change The Search User Data
    public IEnumerator SearchUserDataUpdate(string UserId, string username, string email, string password, string fath, string age, string gender, string education, string designation, string mobilenumber, string address, string city)
    {
        WWWForm form = new WWWForm();
        form.AddField("UserId", UserId);
        form.AddField("newname", username);
        form.AddField("newEmail", email);
        form.AddField("newpassword", password);
        form.AddField("loginfather_name", fath);
        form.AddField("age", age);
        form.AddField("gender", gender);
        form.AddField("education", education);
        form.AddField("designation", designation);
        form.AddField("mobilenumber", mobilenumber);
        form.AddField("address", address);
        form.AddField("city", city);
        message5.text = "";
        message4.text = "";

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/SQL/SearchUserDataUpdata.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                string s = www.downloadHandler.text;
                string[] splitArray = s.Split(char.Parse("_"));
                if ("Record updated successfully" == splitArray[0])
                {
                    display.text = splitArray[0];
                    message4.text = splitArray[1];
                    SearchuserName = splitArray[1];
                    SearchuserEmail = splitArray[2];
                    SearchuserPassword = splitArray[3];
                    SearchFatherName = splitArray[4];
                    SearchAge = splitArray[5];
                    SearchGender = splitArray[6];
                    SearchEducation = splitArray[7];
                    SearchDesignation = splitArray[8];
                    SearchMobilenumber = splitArray[9];
                    SearchAddress = splitArray[10];
                    SearchCity = splitArray[11];
                }

            }
        }
    }




}
