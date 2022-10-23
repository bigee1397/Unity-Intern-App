using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ALogout : MonoBehaviour
{
    public Button ALogOut;

    void Start()
    {
        ALogOut.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        });
    }
}
