using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteSearchUserByAdmin : MonoBehaviour
{

    public Button Delete;

    void Start()
    {
        Delete.onClick.AddListener(() =>
        {
            StartCoroutine(Main.Instance.web.DeleteUseradmin(web.SearchuserId));

        });
    }
}
