using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    
Transform target;

void Start(){

	target = GameObject.FindWithTag("Player").transform;
}

void Update(){

	Vector3 targetPosition = new Vector3(target.position.x, transform.position.y, target.position.z);
	transform.LookAt(targetPosition);
}
}
