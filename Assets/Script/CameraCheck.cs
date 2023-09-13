using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCheck : MonoBehaviour
{
    public GameObject player;
    public Transform check;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player.gameObject.transform.position = Vector3.MoveTowards(player.gameObject.transform.position, check.position, 1000f);
    }
}
