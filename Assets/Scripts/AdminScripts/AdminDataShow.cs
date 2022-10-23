using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminDataShow : MonoBehaviour
{

    public GameObject Admin;
    public GameObject AdminArea;
    public GameObject ShowArea;
    public Text username;
    public static int y = 0;

    public void OnClick()
    {
        while (y == 0)
        {
            AdminArea.SetActive(true);
            ShowArea.SetActive(false);
            y++;
            for (int i = 0; i < displayall.splitArray2.Length - 1; i++)
            {
                username.text = displayall.splitArray2[i];
                GameObject message = Instantiate(Admin, new Vector2(0, 0), Quaternion.identity);
                message.transform.SetParent(AdminArea.transform, false);
            }
        }

        


    }


    /*public void OnDestroy()
    {
        if (y >= 1)
        {
            if (show.x >= 1)
            {
                Destroy(show.AdminArea);
                show.x--;
            }
        }
    }*/

}
