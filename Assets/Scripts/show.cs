using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show : MonoBehaviour
{
    public GameObject Display;
    public GameObject ShowArea;
    public GameObject AdminArea;
    public Text username;
    public static int x = 0;

    public void OnClick()
    {
        
        while (x==0)
        {
            AdminArea.SetActive(false);
            ShowArea.SetActive(true);
            x++;
            for (int i = 0; i < displayall.splitArray1.Length - 1; i++)
            {
                username.text = displayall.splitArray1[i];
                GameObject message = Instantiate(Display, new Vector2(0, 0), Quaternion.identity);
                message.transform.SetParent(ShowArea.transform, false);
            }
        }

       

    }


    /*public void ()
    {
        if (x >= 1)
        {
            if (AdminDataShow.y >= 1)
            {
                //Destroy(AdminDataShow.ShowArea);
                AdminDataShow.y--;
            }

        }
    }*/

}
