﻿using UnityEngine;
using UnityEngine.UI;

public class CL_Transition: MonoBehaviour
{
    public GameObject title;
    private Data data;

    private string Username;
    private string[] Lines;
    private string[] Line;

    // Use this for initialization
    void Start()
    {
        data = GameObject.Find("DataObject").GetComponent<Data>();
        if (data.LanguageToPlay == "English")
        {
            CL_English();
        }
        else
        {
            CL_Français();
        }
    }

    private void CL_English()
    {
        title.GetComponent<Text>().text = "Loading categories";
    }

    private void CL_Français()
    {
        title.GetComponent<Text>().text = "Chargement des catégories";
    }
}