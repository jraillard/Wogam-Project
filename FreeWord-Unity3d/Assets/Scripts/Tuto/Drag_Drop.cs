﻿using System.Collections;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Drag_Drop : MonoBehaviour
{

    public GameObject next;

    void Start()
    {
        StartCoroutine(Time());
    }

    IEnumerator Time()
    {
        yield return new WaitForSeconds(4);
        next.GetComponent<Text>().text = "Next";
    }
}
