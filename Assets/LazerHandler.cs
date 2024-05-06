using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerHandler : MonoBehaviour
{
    public LineRenderer LR;
    public Transform ObjectHolder;
    public List<Transform> list = new List<Transform>();


    private void Start()
    {

        int children = ObjectHolder.childCount;
        if (children > 0)
            list.Clear();

        LR.positionCount = children;
        for (int i = 0; i < children; i++)
        {
            if (ObjectHolder.GetChild(i).position.Equals(Vector3.zero))
                break;
            LR.SetPosition(i, ObjectHolder.GetChild(i).position);
            list.Add(ObjectHolder.GetChild(i));
        }
    }
}
