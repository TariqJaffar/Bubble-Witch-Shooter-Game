using UnityEngine;
using System.Collections;

public class LazerCreator : MonoBehaviour
{
    private Ray RayMouse;
    public Camera Cam;
    public LineRenderer lineRenderer;
    public GameObject gb;
    public float height;
    public LayerMask masking;
  public GameObject HitEffect;
    // Use this for initialization
    void Start()
    {
       // GameObject g = Instantiate(gb, this.transform);
        lineRenderer = lineRenderer.GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Laser();
    }

    public void Laser()
    {
        var mousePos = Input.mousePosition;
        RayMouse = Cam.ScreenPointToRay(new Vector3(mousePos.x, mousePos.y, mousePos.z));
        lineRenderer.enabled = true;
       
        Debug.DrawRay(transform.position, transform.up * 50, Color.black);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, Mathf.Infinity,masking);
        //this.gameObject.transform.rotation.x = new Vector3(RayMouse.origin.x, this.gameObject.transform.rotation.y, this.gameObject.transform.rotation.z);
        this.gameObject.transform.rotation = Quaternion.Euler(RayMouse.origin.x, this.gameObject.transform.rotation.y, this.gameObject.transform.rotation.z);
        lineRenderer.SetPosition(0,new Vector3(0,-3f,0));
        if (hit.collider != null)
        {
            Debug.Log("Collider Name is  : " + hit.collider.name);
            Debug.Log("hitpoint Name is  : " + hit.point);
            // HitEffect = lineRenderer.transform.Find("Hit").gameObject;
            HitEffect.transform.position = new Vector3(RayMouse.origin.x, hit.point.y) ;
            lineRenderer.SetPosition(1,new Vector3(RayMouse.origin.x, hit.point.y, 0));
           
        }
     
    }

}

