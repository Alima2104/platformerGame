using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    
	public float rotationSpeed = 100f;
	
    void Update()
    {
         //distance (in angles) to rotate on each frame. distance = speed * time
        float angle = rotationSpeed * Time.deltaTime;
        //rotate on Y
        transform.Rotate(Vector3.up * angle, Space.World);
    }
}
