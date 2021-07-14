using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour
{
    [SerializeField] List<GameObject> buttonsList;

    private void Start()
    {
        for (int i = 0; i < buttonsList.Count; i++)
        {
            if (i == PlayerPrefs.GetInt("Control"))
            {
                buttonsList[i].GetComponent<Image>().color = new Color(0, 1F, 1F, 1F);
            }
            else
            {
                buttonsList[i].GetComponent<Image>().color = new Color(1F, 1F, 1F, 1F);
            }
        }
    }

    public void Select(int button)
    {
        for (int i = 0; i < buttonsList.Count; i++)
        {
            if (i == button)
            {
                buttonsList[i].GetComponent<Image>().color = new Color(0, 1F, 1F, 1F);
            }
            else
            {
                buttonsList[i].GetComponent<Image>().color = new Color(1F, 1F, 1F, 1F);
            }
        }
    }
}
