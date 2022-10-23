using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class displayall : MonoBehaviour
{
    //public Button display;

    public static string[] splitArray1;
    public static string[] splitArray2;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(GetRequestall("http://localhost/sql/DisplayAllData.php"));
        StartCoroutine(GetRequestAdminAll("http://localhost/sql/DisplayAdminAlldata.php"));

    }


    IEnumerator GetRequestall(string uri)
    {
        
        using (UnityWebRequest www = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {

                Debug.Log(www.downloadHandler.text);



                string s = www.downloadHandler.text;
                splitArray1 = s.Split(char.Parse("*"));


                //display.text = splitArray1[0];



            }
        }
    }



    IEnumerator GetRequestAdminAll(string uri)
    {

        using (UnityWebRequest www = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {

                Debug.Log(www.downloadHandler.text);



                string s = www.downloadHandler.text;
                splitArray2 = s.Split(char.Parse("*"));


                //display.text = splitArray1[0];



            }
        }
    }




}
