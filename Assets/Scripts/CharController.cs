using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]

public class CharController : MonoBehaviour
{
    private Animator _animator;
	private Rigidbody _rigidbody;
	
	private bool _running;
	private float _horizontalInput;
	
	// Start is called before the first frame update
    void Start()
    {
       _animator = GetComponent<Animator>();
	   _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		_horizontalInput = Input.GetAxis("Horizontal");
    }
}
