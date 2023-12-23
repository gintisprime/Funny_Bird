    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public new Vector3 camera;

    void Update()
    {
        
        transform.position = new Vector3(player.position.x + camera.x, player.position.y + camera.y, player.position.z + camera.z);    }
}
