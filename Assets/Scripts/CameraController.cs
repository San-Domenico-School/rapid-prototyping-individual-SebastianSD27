using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**********************************************
 * The script will be attached to the MainCamera
 * The camera follow and be a part of the Vehicle
 * 
 * Sebastian Balakier
 * 9/4/2024
**********************************************/

public class CameraController : MonoBehaviour
{
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

    // Assigns the correct offset to the camera position
    private void FollowPlayer()
    {
        transform.position = vehicleTransform.position + offset;
    }
}
