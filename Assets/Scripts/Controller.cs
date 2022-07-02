using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private CharacterController controller;
    public float gravity = -9.81f;
    public float jumpForce;
    public float speed;
    public float jumpSpeed=0;


    // Start is called before the first frame update
    void Awake()
    {
      controller = GetComponent<CharacterController>();  
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {            
            jumpSpeed = 0;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumpSpeed = jumpForce;
            }
        }

        jumpSpeed += gravity * Time.deltaTime*3f;
        Vector3 dir = new Vector3(horizontal * speed * Time.deltaTime, jumpSpeed * Time.deltaTime, vertical * speed * Time.deltaTime);
        controller.Move(dir);

        if (transform.position.z > 30 && transform.position.z < 35)
        {
            gravity = 5.81f;
        }
        else {
            gravity = -9.81f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Start")
        {
            StartCoroutine("Time");
        }
        if (other.tag == "Finish")
        {
            StopCoroutine("Time");
        }
    }
}
