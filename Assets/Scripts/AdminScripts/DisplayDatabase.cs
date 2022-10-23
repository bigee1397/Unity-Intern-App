using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class DisplayDatabase : MonoBehaviour
{
    public Text id;
    public Text user;
    public Text pass;
    public Text database;


    void Start()
    {
        StartCoroutine(GetRequestall("http://localhost/sql/Connection.php"));

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
                string[] splitArray1 = s.Split(char.Parse("_"));
                if ("connected" == splitArray1[0])
                {
                    id.text = splitArray1[1];
                    user.text = splitArray1[2];
                    pass.text = splitArray1[3];
                    database.text = splitArray1[4];
                }

            }
        }
    }
}
