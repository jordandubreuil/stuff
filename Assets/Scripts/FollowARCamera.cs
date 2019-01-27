using UnityEngine;
using System.Collections;

public class FollowARCamera : MonoBehaviour
{

    public GameObject cameraOBJ;

    private Vector3 offset;

    void Start()
    {
        cameraOBJ = GameObject.FindGameObjectWithTag("MainCamera");
        offset = transform.position - cameraOBJ.transform.position;
    }

    void LateUpdate()
    {
        transform.position = cameraOBJ.transform.position + offset;
    }
}
