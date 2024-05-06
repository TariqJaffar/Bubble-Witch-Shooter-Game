using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam
{
    Vector3 pos, dir;
    GameObject laserObj;
    LineRenderer laser;
    List<Vector2> laserIndices = new List<Vector2>();


    public LaserBeam(Vector2 pos,Vector2 dir,Material material)
    {
        this.laser = new LineRenderer();
        this.laserObj = new GameObject();
        this.laserObj.name = "LaserBeam";
        this.pos = pos;
        this.dir = dir;
        this.laser = this.laserObj.AddComponent(typeof(LineRenderer)) as LineRenderer;
        this.laser.startWidth = 0.1f;
        this.laser.endWidth = 0.1f;
        this.laser.material = material;
        this.laser.startColor = Color.green;
        this.laser.endColor = Color.green;


        castRay(pos ,dir,laser);
    }


    void castRay(Vector2 pos,Vector2 dir,LineRenderer laser)
    {
        laserIndices.Add(pos);
        Ray ray = new Ray(pos, dir);
        RaycastHit hit;
        if(Physics.Raycast(ray.origin,ray.direction,out hit, 1))
        {
            laserIndices.Add(hit.point);
            updateLaser();
        }
        else
        {
            laserIndices.Add(ray.GetPoint(30));
            updateLaser();
        }
    }

    void updateLaser()
    {
        int count = 0;
        laser.positionCount = laserIndices.Count;
        foreach (Vector3 idx in laserIndices)
        {
            laser.SetPosition(count, idx);
            count++;
        }
    }


}

