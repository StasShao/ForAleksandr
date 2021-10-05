using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject pl;
    public float camSpeed;
    public Vector3 Offset;
   
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void LateUpdate()
    {
        transform.LookAt(pl.transform);
        transform.position = Vector3.Lerp(transform.position, pl.transform.position, camSpeed) +Offset;
    }
}
