using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONeneableDisabel : MonoBehaviour
{
    private void OnEnable()
    {
        DrawLine.instance.drwaline = false;
    }


    private void OnDisable()
    {
        DrawLine.instance.drwaline = true;

    }
}
