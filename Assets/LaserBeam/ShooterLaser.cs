using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterLaser : MonoBehaviour
{

    public Material material;
    LaserBeam beam;
    private void Update()
    {
        Destroy(GameObject.Find("Laser Beam"));
        beam = new LaserBeam(gameObject.transform.position, gameObject.transform.up, material);
    }
}
