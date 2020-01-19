using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody rb;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Update()
    {
        //moveInput = new Vector3(Input.GetAxisRaw("L_Horizontal"), 0f, Input.GetAxisRaw("L_Vertical")); 
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        var testInput1 = new Vector3(Input.GetAxisRaw("RVertical"), 0f, Input.GetAxisRaw("RHorizontal"));
        var testInput2 = new Vector3(Input.GetAxisRaw("LVertical"), 0f, Input.GetAxisRaw("LHorizontal"));

        ControlsDebug(testInput1, testInput2);

        JoyRotate();


        moveVelocity = moveInput * moveSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = moveVelocity;
    }

    void ControlsDebug(Vector3 input1, Vector3 input2)
    {
        if (input1.x > (0.4f))
        {
            Debug.Log("input1.x " + input1.x);
        }
        if(input1.x < (-0.4f))
        {
            Debug.Log("input1.x " + input1.x);
        }
        if (input1.z > (0.4f))
        {
            Debug.Log("input1.z " + input1.x);
        }
        if (input1.z < (-0.4f))
        {
            Debug.Log("input1.z " + input1.x);
        }

        if (input2.x > (0.4f))
        {
            Debug.Log("input2.x " + input2.x);
        }
        if (input2.x < (-0.4f))
        {
            Debug.Log("input2.x " + input2.x);
        }
        if (input2.z > (0.4f))
        {
            Debug.Log("input2.z " + input2.z);
        }
        if (input2.z < (-0.4f))
        {
            Debug.Log("input2.z " + input2.z);
        }

    }

    void JoyRotate()
    {
        Vector3 rotVector = new Vector3(Input.GetAxisRaw("RHorizontal"),0f,0f) + Vector3.left * Input.GetAxisRaw("RVertical");
        // + Vector3.left * Input.GetAxisRaw("RVertical")
        if (Input.GetAxisRaw("RHorizontal") != 0 || Input.GetAxisRaw("RVertical") != 0)
        {
            //transform.rotation = Quaternion.LookRotation(rotVector, Vector3.forward );
            Quaternion eulerRot = Quaternion.Euler(0.0f, 0.0f, rotVector.y);
            transform.rotation = Quaternion.Slerp(transform.rotation, eulerRot, Time.deltaTime * 10);
        }

        
    }
}
