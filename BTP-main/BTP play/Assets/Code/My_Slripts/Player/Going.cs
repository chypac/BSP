using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Timeline;
public class Going : MonoBehaviour
{
    private CharacterController cc;

    public float graviry = - 9.8f;
    public float speed = 15.0f;

    public float jspeed = 0.0f;
    public float jumpForce = 15;
   // Vector3 moveVelocity;
    private void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    private void Update()
     {
        float horizontal = 0;
        float vertical = 0;
        horizontal = Input.GetAxis("Horizontal") * speed;
        vertical = Input.GetAxis("Vertical") * speed;
        if (cc.isGrounded)
        {


            //moveVelocity = transform.forward * horizontal;
            jspeed = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jspeed = jumpForce;
            }
        }
        jspeed += graviry * Time.deltaTime * 3f;
        Vector3 dir = new Vector3(horizontal  , jspeed, vertical );

        dir *= Time.deltaTime;
        dir = transform.TransformDirection(dir);
        cc.Move(dir);
     }
}