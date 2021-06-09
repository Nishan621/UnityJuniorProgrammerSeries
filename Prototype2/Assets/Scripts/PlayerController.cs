using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public Transform projectileSpawnPoint;
  private float horizontalInput;
  private float verticalInput;
  private float speed = 40.0f;
  private float xRange = 20.0f;
  private float zRange = 20.0f;

  public GameObject projectilePrefab;



  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {



    if (transform.position.x < -xRange)
    {
      transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
    }

    if (transform.position.x > xRange)
    {
      transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }
    if (transform.position.z > zRange)
    {
      transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
    }

    if (transform.position.z < 0)
    {
      transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }

    horizontalInput = Input.GetAxis("Horizontal");
    verticalInput = Input.GetAxis("Vertical");
    transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
    transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);

    if (Input.GetKeyDown(KeyCode.Space))
    {
      //  Launch the projecitle of food
      Instantiate(projectilePrefab, projectileSpawnPoint.position, projectilePrefab.transform.rotation);
    }
  }

}

