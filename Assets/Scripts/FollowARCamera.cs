using UnityEngine;
using System.Collections;

public class FollowARCamera : MonoBehaviour
{
    public GameObject cameraOBJ;
    public bool follow = true;
    public Vector3 camOffset = new Vector3(0, -1, 3);

    void Start()
    {
        cameraOBJ = GameObject.FindGameObjectWithTag("MainCamera");        
    }

    void LateUpdate()
    {
        if (follow)
        {
            transform.position = cameraOBJ.transform.position +
            cameraOBJ.transform.right * camOffset.x +
            cameraOBJ.transform.up * camOffset.y +
            cameraOBJ.transform.forward * camOffset.z;
            transform.rotation = Quaternion.LookRotation(Vector3.Normalize(cameraOBJ.transform.position - transform.position));
        }
    }
}
