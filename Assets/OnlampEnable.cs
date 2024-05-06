using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlampEnable : MonoBehaviour
{
    public Transform Image;
    private void OnEnable()
    {
        Image.gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        Image.gameObject.SetActive(true);

    }
}
