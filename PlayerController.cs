using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;

    public GameObject projectilePrefab;

    //Below method can be used to mimite player's x axis moment
    // public float leftBoundry = -10.0f;
    //public float rightBoundry = 10.0f;

    //But we are using this method

    public float xrange = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Bwlow method can be used to mimite player's x axis moment

        //  if (transform.position.x < -10)
        //  {
        //     transform.position = new Vector3(leftBoundry, transform.position.y, transform.position.z);
        //  }

        //Bwlow method can be used to mimite player's x axis moment

        //  if(transform.position.x > 10)
        // {
        //      transform.position = new Vector3(rightBoundry, transform.position.y, transform.position.z);
        //  }

        //But we are using this method
        //Keep the player in bound

        if (transform.position.x < -xrange)
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xrange)
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        //Get the input key Space bar from the user
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}
