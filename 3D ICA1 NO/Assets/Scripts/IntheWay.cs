using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntheWay : MonoBehaviour
{
    [SerializeField] private GameObject solidBody;
    [SerializeField] private GameObject transBody;

    private void awake()
    {
        ShowSolid();
    }

    public void ShowSolid()
    {
        solidBody.SetActive(true);
        transBody.SetActive(false);
    }

    public void ShowTransparent() {
        solidBody.SetActive(false);
        transBody.SetActive(true);

    }

}
