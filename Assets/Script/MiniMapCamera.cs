using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapCamera : MonoBehaviour
{
    public Transform PlayerMinimap;
 

    // Update is called once per frame
    void Update()
    {
        UpdateCamPosition();
    }

    void UpdateCamPosition()
    {
        Vector3 camPos = PlayerMinimap.position;
        camPos.y = transform.position.y;
        transform.position = camPos;
    }
}
