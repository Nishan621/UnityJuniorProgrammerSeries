using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

  private float speed = 20.0f;
  private float turnSpeed = 45.0f;
  private float horizontalInput;
  private float verticalInput;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // Move the vehicle forward

    horizontalInput = Input.GetAxis("Horizontal");
    verticalInput = Input.GetAxis("Vertical");

    // Moves the truck forward based on vertical input
    transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

    // Rotates the truck based on horizontal input
    transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

  }
}
