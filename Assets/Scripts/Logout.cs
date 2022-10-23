using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logout : MonoBehaviour
{

    public Button LogOut;

    void Start()
    {
        LogOut.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        });
    }


}
