using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Drapdown : MonoBehaviour
{

    //public Text mesages;
    public static string Username;
    



    void Update()
    {
        StartCoroutine(GetRequest("http://localhost/sql/DIsplayNuberofUser.php"));
    }
    IEnumerator GetRequest(string uri)
    {
        Username = "";
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
                string[] splitArray = s.Split(char.Parse("_"));

                var dropdown = transform.GetComponent<Dropdown>();


                dropdown.options.Clear();
                foreach (var item in splitArray)
                {
                    dropdown.options.Add(new Dropdown.OptionData() { text = item });
                }

                dropdownSelect(dropdown);
                dropdown.onValueChanged.AddListener(delegate { dropdownSelect(dropdown); });


            }
        }
    }

    public void dropdownSelect(Dropdown dropdown)
    {
        int index = dropdown.value;
       // mesages.text= dropdown.options[index].text;
        Username = dropdown.options[index].text;
    }
}
