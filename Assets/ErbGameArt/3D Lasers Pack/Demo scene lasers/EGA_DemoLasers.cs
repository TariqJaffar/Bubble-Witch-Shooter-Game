using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System;
using UnityEngine;

public class EGA_DemoLasers : MonoBehaviour
{
    public GameObject FirePoint;
    public Camera Cam;
    public float MaxLength;
    public GameObject[] Prefabs;

    private Ray RayMouse;
    private Vector3 direction;
    private Quaternion rotation;

    [Header("GUI")]
    private float windowDpi;

    private int Prefab;
    private GameObject Instance;
    private EGA_Laser LaserScript;
    Vector2 LaserEndPoint;
    //Double-click protection
    private float buttonSaver = 0f;
    public LineRenderer Inchild;
    void Start ()
    {
        LaserEndPoint = new Vector3(0, 0, 0);
        if (Screen.dpi < 1) windowDpi = 1;
        if (Screen.dpi < 200) windowDpi = 1;
        else windowDpi = Screen.dpi / 200f;
        Counter(0);
    }

    void Update()
    {
        //Enable lazer
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(Instance);
            Instance = Instantiate(Prefabs[Prefab], FirePoint.transform.position, FirePoint.transform.rotation);
            Instance.transform.parent = transform;
            LaserScript = Instance.GetComponent<EGA_Laser>();
        }

        //Disable lazer prefab
        if (Input.GetMouseButtonUp(0))
        {
            LaserScript.DisablePrepare();
            Destroy(Instance,1);
        }

        //To change lazers
        if ((Input.GetKey(KeyCode.A) || Input.GetAxis("Horizontal") < 0) && buttonSaver >= 0.4f)// left button
        {
            buttonSaver = 0f;
            Counter(-1);
        }
        if ((Input.GetKey(KeyCode.D) || Input.GetAxis("Horizontal") > 0) && buttonSaver >= 0.4f)// right button
        {
            buttonSaver = 0f;
            Counter(+1);         
        }
        buttonSaver += Time.deltaTime;
        

        //Current fire point
        if (Cam != null)
        {
           /// RaycastHit hit; //DELATE THIS IF YOU WANT USE LASERS IN 2D
           // var mousePos = Input.mousePosition;
          //  RayMouse = Cam.ScreenPointToRay(new Vector3 (mousePos.x,mousePos.y,mousePos.z));
         
            //ADD THIS IF YOU WANNT TO USE LASERS IN 2D: RaycastHit2D hit = Physics2D.Raycast(RayMouse.origin, RayMouse.direction, MaxLength);
             RaycastHit2D hit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition),MaxLength); ;
            // RaycastHit2D hit = Physics2D.Raycast(this.transform.position,Vector2.up , MaxLength);
           // if (Physics.Raycast(this.transform.position, transform.TransformDirection(Vector3.up), out hit, MaxLength)) //CHANGE THIS IF YOU WANT TO USE LASERRS IN 2D: if (hit.collider != null)
            //  if (Physics.Raycast(RayMouse.origin, RayMouse.direction, out hit, MaxLength))
           // Debug.DrawRay(RayMouse.origin, RayMouse.direction, Color.blue);
          
            if (hit.collider != null)
            {
                Debug.Log("2d hit by array" + hit.collider.name);
              
                RotateToMouseDirection(gameObject, hit.point);
                EGA_Laser.LAserENDPOINT = new Vector3(hit.normal.x, hit.normal.y);
                    Inchild =  this.gameObject.GetComponentInChildren<LineRenderer>();
            }
            else
            {
                    var pos = RayMouse.GetPoint(MaxLength);
                    RotateToMouseDirection(gameObject, pos);
                    LaserEndPoint = pos;
                }
        }
        else
        {
            Debug.Log("No camera");
        }
    }

    //GUI Text
    void OnGUI()
    {
        GUI.Label(new Rect(10 * windowDpi, 5 * windowDpi, 400 * windowDpi, 20 * windowDpi), "Use the keyboard buttons A/<- and D/-> to change lazers!");
        GUI.Label(new Rect(10 * windowDpi, 20 * windowDpi, 400 * windowDpi, 20 * windowDpi), "Use left mouse button for shooting!");
    }

    //To change prefabs (count - prefab number)
    void Counter(int count)
    {
        Prefab += count;
        if (Prefab > Prefabs.Length - 1)
        {
            Prefab = 0;
        }
        else if (Prefab < 0)
        {
            Prefab = Prefabs.Length - 1;
        }
    }
  
    //To rotate fire point
    void RotateToMouseDirection (GameObject obj, Vector3 destination)
    {
        direction = destination - obj.transform.position;
        rotation = Quaternion.LookRotation(direction);     
        obj.transform.localRotation = Quaternion.Lerp(obj.transform.rotation, rotation, 1);
    }
    void OnDrawGizmosSelected()
    {
        // Draws a 5 unit long red line in front of the object
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(Vector3.up) * 15;
        Gizmos.DrawRay(transform.position, direction);
    }
}
