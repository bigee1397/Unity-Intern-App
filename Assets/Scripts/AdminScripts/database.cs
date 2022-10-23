using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class database : MonoBehaviour
{

    [SerializeField] GameObject Yes;
    [SerializeField] GameObject No;

    public static string Ip;
    public static string User;
    public static string Password;
    public static string Databasename;


    public static string[] splitArray1;
    void Start()
    {
        StartCoroutine(GetRequestall("http://localhost/sql/Connection.php"));

    }


    IEnumerator GetRequestall(string uri)
    {

        using (UnityWebRequest www = UnityWebRequest.Get(uri))
        {
            Yes.SetActive(false);
            No.SetActive(false);
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
                splitArray1 = s.Split(char.Parse("_"));
                if ("connected"==splitArray1[0])
                {
                    Yes.SetActive(true);
                    No.SetActive(false);
                    Ip = splitArray1[1];
                    User = splitArray1[2];
                    Password = splitArray1[3];
                    Databasename = splitArray1[4];
                }
                else
                {
                    Yes.SetActive(false);
                    No.SetActive(true);
                }

            }
        }
    }
}
