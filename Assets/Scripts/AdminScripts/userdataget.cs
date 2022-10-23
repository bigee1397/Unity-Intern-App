using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class userdataget : MonoBehaviour
{
    public Button user;
    string s;
    public static string[] splitArray;
    // Start is called before the first frame update
    void Start()
    {
        //var dropdown = transform.GetComponent<Dropdown>();

        user.onClick.AddListener(() =>
        {
            StartCoroutine(GetRequest("http://localhost/sql/DIsplayNuberofUser.php"));
        });
    }

    IEnumerator GetRequest(string uri)
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

                

                s = www.downloadHandler.text;
                splitArray = s.Split(char.Parse("_"));
                

            }
        }
    }


}
