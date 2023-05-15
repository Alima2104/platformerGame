using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyController : MonoBehaviour {
    // Range of movement
    public float rangeY = 2f;
    // Speed
    public float speed = 3f;
    // Initial direction
    public float direction = 1f;
    // To keep the initial position
    Vector3 initialPosition;
    // Use this for initialization
    void Start () {
        // Initial location in Y
        initialPosition = transform.position;
    }
  
    // Update is called once per frame
    void Update () {
		// How much we are moving
        float movementY = direction * speed * Time.deltaTime;
        // New position
        float newY = transform.position.y + movementY;
        // Check whether the limit would be passed
        if (Mathf.Abs(newY - initialPosition.y) > rangeY)
        {
            // Move the other way
            direction *= -1;
        }
        // If it can move further, move
        else
        {
            // Move the object
            transform.Translate(new Vector3(0, movementY, 0));
        }        
    
    }
}