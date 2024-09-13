using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**********************************************
 * The script will be attached to the MainCamera
 * The camera follow and be a part of the Vehicle
 * 
 * Sebastian Balakier
 * September 11, 2024 Version 1.0
**********************************************/

public class CameraController : MonoBehaviour
{
    [Tooltip("Drag Vehicle onto Vehicle Transform")]
    [SerializeField] private Transform vehicleTransform;   // Holds the Transform component of the player
    private Vector3 offset;   // Holds the position vector that  the camera will maintain from the player

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 5, -7);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        FollowPlayer();
    }

    // Updates camera position per frame just after Update
    private void FollowPlayer()
    {
        transform.position = vehicleTransform.position + offset;
    }
}
